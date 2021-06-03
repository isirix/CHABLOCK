using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CHABLOCK
{
    public class Block
    {
        private readonly DateTime _timeStamp;
        private string _MkRootHash = "";
        public long _nonce;
        public string PreviousHash { get; set; }
        public List<Transaction> Transactions { get; set; }

        public string Hash { get; set; }

        public Block(DateTime timeStamp, List<Transaction> transactions, string previousHash = "")
        {
            _timeStamp = timeStamp;
            _nonce = 0;
            Transactions = transactions;
            PreviousHash = previousHash;
            Hash = CreateHash();
        }

        public void MineBlock(int p난이도)
        {
            string 난이도 = new String('0', p난이도);
            _MkRootHash = GetMkRoot();
            while (Hash.Substring(0, p난이도) != 난이도)
            {
                _nonce++;
                Hash = CreateHash();
            }
            Console.WriteLine("TimeStamp = {0} / Nonce = {1} / Hash = {2}", _timeStamp, _nonce, Hash);
        }

        public string CreateHash()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string data = PreviousHash + _timeStamp + _MkRootHash + _nonce;
                return GetHash(data);
            }
        }

        private string GetMkRoot()
        {
            string tmp = "";
            List<string> TranHash = new List<string>();
            foreach (Transaction tran in Transactions)
            {
                TranHash.Add(GetHash(tran.From + ">" + tran.To + ":" + tran.Amount));
            }

            while (TranHash.Count != 1)
            {
                List<string> tmpList = new List<string>();
                for (int i = 1; i < TranHash.Count; i += 2)
                {
                    if (TranHash.Count == i)
                        tmp = TranHash[i - 1];
                    else
                        tmp = TranHash[i - 1] + TranHash[i];

                    tmpList.Add(GetHash(tmp));
                }

                TranHash = tmpList;
            }

            return TranHash[0];
        }

        private string GetHash(string pStr)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.Default.GetBytes(pStr));
                var sBuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sBuilder.Append(bytes[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}
