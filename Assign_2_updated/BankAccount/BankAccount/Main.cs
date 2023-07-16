using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class program
    {
        public static void Main(string[] args)
        {
            Bank bank= new Bank();

            SavingAccount saving = new SavingAccount(9898,"Husnain Ali",2000,8);
            Console.WriteLine("");
            Console.WriteLine("__________________________________Saving Account__________________________________                    ");
            Console.WriteLine("");
            saving.ExecuteTransaction(50);
            saving.PrintTransaction();
           // saving.Deposit(100);
            //saving.Withdraw(50);
            bank.AddAccount(saving);
            BankAccount saving1 = bank.GetAccount(9898);
            saving1.PrintStatement();







            CheckingAccount check = new CheckingAccount(8989,"Ali Akbar",3000);
            Console.WriteLine("");
            Console.WriteLine("__________________________________Checking Account__________________________________                    ");
            Console.WriteLine("");
            check.ExecuteTransaction(10);
            check.PrintTransaction();
           // check.Deposit(300);
            bank.AddAccount(check);
            BankAccount check1 = bank.GetAccount(8989);
            check1.PrintStatement();



            LoanAccount loan = new LoanAccount(9090,"Ali",500,4);
            Console.WriteLine("");
            Console.WriteLine("__________________________________Loan Account__________________________________                    ");
            Console.WriteLine("");
            loan.ExecuteTransaction(250);
            loan.PrintTransaction();
           // loan.Deposit(500);
            bank.AddAccount(loan);
            BankAccount loan1 = bank.GetAccount(9090);
            loan1.PrintStatement();


          
           


            Console.ReadKey();
        }
        
    }
}
