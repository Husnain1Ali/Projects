using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{

    public class LoanAccount : BankAccount,ITransaction
    {
        public decimal interes_rate;
        public LoanAccount(int Account_No, string Account_Holder_Name, decimal Balance, decimal interes_rate) : base(Account_No, Account_Holder_Name, Balance)
        {
            this.interes_rate = interes_rate;
        }
        public override void CalculateInterest(decimal amount)
        {
            decimal interest = amount * interes_rate;
            amount = amount + interest;
            base.Deposit(amount);

        }
        public void ExecuteTransaction(decimal amount)
        {
            Console.WriteLine("The balance in loanAccount is " + Get_Balance());
            Deposit(amount);
        }

        public void PrintTransaction()
        {
            Console.WriteLine("Transaction of Loan Acccount");
        }
    }

}
