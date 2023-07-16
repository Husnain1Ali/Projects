using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
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
            Deposit(amount);
        }

          public void PrintTransaction()
        {
            Console.WriteLine("Transaction of Checking Acccount");
        }


    }
}
