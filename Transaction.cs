using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHABLOCK
{
    public class Transaction
    {
        public string From;
        public string To;
        public double Amount;
        public Transaction(string from, string to, double amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
