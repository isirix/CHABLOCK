using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHABLOCK
{
    public class BlockChain
    {
        private readonly int _난이도;
        private readonly double _miningReward;
        public List<Transaction> _pendingTransactions;
        public List<Block> Chain { get; set; }
        public BlockChain(int p난이도, int miningReward)
        {
            _난이도 = p난이도;
            _miningReward = miningReward;
            _pendingTransactions = new List<Transaction>();
            Chain = new List<Block> { CreateGenesisBlock() };
        }

        public void MineBlock(string minerAddress)
        {
            Transaction minerRewardTransaction = new Transaction("", minerAddress, _miningReward);
            _pendingTransactions.Add(minerRewardTransaction);
            Block block = new Block(DateTime.Now, _pendingTransactions);
            block.PreviousHash = Chain.Last().Hash;
            block.MineBlock(_난이도);
            Chain.Add(block);

        }
        public bool IsValidChain()
        {
            for (int i = 1; i < Chain.Count; i++)
            {
                Block previousBlock = Chain[i - 1];
                Block currentBlock = Chain[i];
                if (currentBlock.Hash != currentBlock.CreateHash())
                    return false;
                if (currentBlock.PreviousHash != previousBlock.Hash)
                    return false;
            }
            return true;
        }
        public double GetBalance(string address)
        {
            double balance = 0;
            foreach (Block block in Chain)
            {
                foreach (Transaction transaction in block.Transactions)
                {
                    if (transaction.From == address)
                    {
                        balance -= transaction.Amount;
                    }
                    if (transaction.To == address)
                    {
                        balance += transaction.Amount;
                    }
                }
            }
            return balance;
        }
        private Block CreateGenesisBlock()
        {
            List<Transaction> transactions = new List<Transaction> { new Transaction("", "채굴자", 100) };
            return new Block(DateTime.Now, transactions, "0");
        }
    }
}
