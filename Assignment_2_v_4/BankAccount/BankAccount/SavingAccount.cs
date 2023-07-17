using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   /*Here we made a savingAccount class which is a child class BankAccount class, it shows inheritance here and we also inherit interface*/
    public class SavingAccount : BankAccount, ITransaction                 
    {
        decimal interest_rate;                                           // Here we are intialing an additional attribute of interest_rate 


        public SavingAccount(int Account_No, string Account_Holder_Name, decimal Balance, decimal interest_rate) : base(Account_No, Account_Holder_Name, Balance)                   //Making Constructor and adding one new parameter
        {
            this.interest_rate = interest_rate;               
        }
        public override void CalculateInterest(decimal amount)                     
        {           
            /* In this method we are overriding the base class method name as CalculateInterest and here it shows polymorphism property of method overriding and we are also getting value of amount by passing amount parameter*/

            decimal interest = amount * interest_rate;
            amount = amount + interest;

            /* In the above two lines we are getting the interest on given amount and adding the interest into amount*/
            base.Deposit(amount);                             // Here we are adding the above amount in the Balance by calling base Deposit Method
        }
      

        public void ExecuteTransaction(decimal amount)
        {   
            //Here we are defing the ExecuteTranscation method of interface which is compalsory to define and getting the amount amount by passing amount parameter

            Console.WriteLine("The balance in SvingAccount is " + Get_Balance());
            Deposit(amount);      // Here we are adding the above amount in the Balance by calling base Deposit Method
        }

        public void PrintTransaction()
        {
            //Here we are defing the PrintTranscation method of interface which is compalsory to define and getting the amount amount by passing amount parameter

            Console.WriteLine("Transaction of Saving Acccount");
        }


    }
}