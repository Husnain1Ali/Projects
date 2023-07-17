using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /*Here we made a CheckingAccount class which is a child class BankAccount class, it shows inheritance here and we also inherit interface*/
    public class LoanAccount : BankAccount, ITransaction
    {
        public decimal interes_rate;                       // Here we are intialing an additional attribute of interest_rate
        public LoanAccount(int Account_No, string Account_Holder_Name, decimal Balance, decimal interes_rate) : base(Account_No, Account_Holder_Name, Balance)
        {
            this.interes_rate = interes_rate;
        }
        public override void CalculateInterest(decimal amount)      
        {
            /* In this method we are overriding the base class method name as CalculateInterest and here it shows polymorphism property of method overriding and we are also getting value of amount by passing amount parameter*/

            decimal interest = amount * interes_rate;
            amount = amount + interest;
            base.Deposit(amount);

        }
        public void ExecuteTransaction(decimal amount)
        {
            //Here we are defing the ExecuteTranscation method of interface which is compalsory to define and getting the amount amount by passing amount parameter

            Console.WriteLine("The balance in loanAccount is " + Get_Balance());
            Deposit(amount);
        }

        public void PrintTransaction()
        {
            //Here we are defing the PrintTranscation method of interface which is compalsory to define and getting the amount amount by passing amount parameter

            Console.WriteLine("Transaction of Loan Acccount");
        }
    }

}