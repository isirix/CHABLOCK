using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CHABLOCK
{
    public partial class Form1 : Form
    {
        BlockChain _BlockChain = new BlockChain(5, 10);
        private List<Transaction> _WaitTransactions = new List<Transaction>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTran_Click(object sender, EventArgs e)
        {
            _WaitTransactions.Add(new Transaction(tbxFrom.Text, tbxTo.Text, Convert.ToDouble(tbxAmount.Text)));
            rtbxInfo.Text += tbxFrom.Text + " 주소에서 " + tbxTo.Text + " 주소로 " + tbxAmount.Text + "개를 전송하는 트랜잭션을 생성했습니다." + Environment.NewLine;
        }

        private void Mine_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            _BlockChain.MineBlock("채굴자");
            PrintBlock();
            this.Cursor = Cursors.Default;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (_BlockChain.IsValidChain())
                rtbxInfo.Text += "모든 블록이 유효합니다." + Environment.NewLine;
            else
                rtbxInfo.Text += "조작된 블록이 존재합니다." + Environment.NewLine;
        }
        
        private void PrintBlock()
        {
            int i = 0;
            rtbxAllBlocks.Text = "";
            string tmp = "";
            foreach (Block block in _BlockChain.Chain)
            {
                i++;
                tmp += Environment.NewLine;
                tmp += i.ToString() + "번 블록" + Environment.NewLine;
                tmp += "이전 블록 해시: " + block.PreviousHash + Environment.NewLine;
                tmp += "현재 블록 해시: " + block.Hash + Environment.NewLine;
                tmp += "Nonce: " + block._nonce + Environment.NewLine;
                tmp += "<<<< 트랜잭션 Read >>>>" + Environment.NewLine;
                foreach (Transaction transaction in block.Transactions)
                {
                    if (transaction.From == "")
                        tmp += transaction.To + "에게 블록생성 보상 " + transaction.Amount + Environment.NewLine;
                    else
                        tmp += "★" + transaction.From + "--->" + transaction.To + " : " + transaction.Amount + Environment.NewLine;
                }

                rtbxAllBlocks.Text = tmp + rtbxAllBlocks.Text;
                tmp = "";                
            }
        }

        private void btnGetVal_Click(object sender, EventArgs e)
        {
            double SenderMoney = _BlockChain.GetBalance(tbxFrom.Text);
            rtbxInfo.Text += tbxFrom.Text + " 잔액: " + SenderMoney.ToString() + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintBlock();

            Thread T = new Thread(MineBlock);
            T.Start();

            this.FormClosed += delegate { T.Abort(); };
        }

        private void MineBlock()
        {   
            while (true)
            {
                _BlockChain._pendingTransactions = _WaitTransactions;
                _WaitTransactions = new List<Transaction>();
                _BlockChain.MineBlock("채굴자");
                this.Invoke((MethodInvoker)delegate
                {
                    PrintBlock();
                });
            }
        }

    }
}
