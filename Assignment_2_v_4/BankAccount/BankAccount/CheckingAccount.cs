using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /*Here we made a CheckingAccount class which is a child class BankAccount class, it shows inheritance here and we also inherit interface*/
    public class CheckingAccount : BankAccount, ITransaction
    {

        public CheckingAccount(int Account_No, string Account_Holder_Name, decimal Balance) : base(Account_No, Account_Holder_Name, Balance)
        {

        }
        public override void CalculateInterest(decimal amount)
        {
            Console.WriteLine("There is no interest in Checking account");
        }

        public void ExecuteTransaction(decimal amount)
        {
            //Here we are defing the ExecuteTranscation method of interface which is compalsory to define and getting the amount amount by passing amount parameter

            Console.WriteLine("The balance in CheckingAccount is " + Get_Balance());
            Deposit(amount);
        }

        public void PrintTransaction()
        {
            //Here we are defing the PrintTranscation method of interface which is compalsory to define and getting the amount amount by passing amount parameter

            Console.WriteLine("Transaction of Checking Acccount");
        }


    }
}