using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingAccount : BankAccount, ITransaction
    {
        decimal interest_rate;


        public SavingAccount(int Account_No, string Account_Holder_Name, decimal Balance, decimal interest_rate) : base(Account_No, Account_Holder_Name, Balance)                   //Making Constructor and adding one new parameter
        {
            this.interest_rate = interest_rate;
        }
        public override void CalculateInterest(decimal amount)
        {
            decimal interest = amount * interest_rate;
            amount = amount + interest;
            base.Deposit(amount);
        }

        public void ExecuteTransaction(decimal amount)
        {
            Console.WriteLine("The balance in SvingAccount is " + Get_Balance());
            Deposit(amount); 
        }

        public void PrintTransaction()
        {
            Console.WriteLine("Transaction of Saving Acccount");
        }


    }
}
