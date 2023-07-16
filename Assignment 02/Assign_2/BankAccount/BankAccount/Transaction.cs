using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Transaction
    {
       public decimal type;
        public decimal amount;
        public Transaction(decimal type, decimal amount)
        {
            this.type = type;
            this.amount = amount;
        }
    
    public void PrintTransaction()
        {
            Console.WriteLine("{0}: {1:C}", type, amount);
        }
    
    }
}
