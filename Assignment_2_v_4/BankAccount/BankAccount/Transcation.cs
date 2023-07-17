using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    // Here we are making a class of Transcation in which we are intializing the attribute type and amount. We are also adding each transtion in the list of transcations which we have intialized in BankAccount class  
    public class Transaction
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
            // In this method we are checking which transaction is happening and what amount is used in transcation

            Console.WriteLine("{0}: {1:C}", type, amount);
        }

    }
}