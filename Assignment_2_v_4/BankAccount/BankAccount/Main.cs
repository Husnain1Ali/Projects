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
            Bank bank = new Bank();                           // Here we are making the object of bank class

            SavingAccount saving = new SavingAccount(9898, "Husnain Ali", 2000, 8);                    // Here we are making object of SavingAccount class and giving the attributes values here
            Console.WriteLine("");
            Console.WriteLine("__________________________________Saving Account__________________________________                    ");
            Console.WriteLine("");
            saving.ExecuteTransaction(50);                               //calling the ExecuteTransction method in savingclass and giving the amount value 50 
            saving.PrintTransaction();
            saving.CalculateInterest(9);                                  //calling the Calculate interest method and giving the amount value 9
            // saving.Deposit(100);
            saving.Withdraw(50);
            bank.AddAccount(saving);                                     //Here we are caaling the add acount method in Bank class to add account of saving class
            BankAccount saving1 = bank.GetAccount(9898);
            saving1.PrintStatement();







            CheckingAccount check = new CheckingAccount(8989, "Ali Akbar", 3000);               // Here we are making object of CheckingAccount class and giving the attributes values here
            Console.WriteLine("");
            Console.WriteLine("__________________________________Checking Account__________________________________                    ");
            Console.WriteLine("");
            check.ExecuteTransaction(10);                                                       //calling the ExecuteTransction method in checkingAccount class and giving the amount value 10
            check.PrintTransaction();
            check.Withdraw(40);
            // check.Deposit(300);
            bank.AddAccount(check);                                                              //Here we are calling the add acount method in Bank class to add account of checkingAccount class
            BankAccount check1 = bank.GetAccount(8989);
            check1.PrintStatement();



            LoanAccount loan = new LoanAccount(9090, "Ali", 500, 4);                           // Here we are making object of loanAccount class and giving the attributes values here
            Console.WriteLine("");
            Console.WriteLine("__________________________________Loan Account__________________________________                    ");
            Console.WriteLine("");
            loan.ExecuteTransaction(250);                                                        //calling the ExecuteTransction method in loan class and giving the amount value 250
            loan.PrintTransaction();
            loan.CalculateInterest(50);                                                           //calling the Calculate interest method and giving the amount value 50
            // loan.Deposit(500);
            loan.Withdraw(100);
            bank.AddAccount(loan);                                                                  //Here we are calling the add acount method in Bank class to add account of loan class
            BankAccount loan1 = bank.GetAccount(9090);
            loan1.PrintStatement();






            Console.ReadKey();
        }

    }
}