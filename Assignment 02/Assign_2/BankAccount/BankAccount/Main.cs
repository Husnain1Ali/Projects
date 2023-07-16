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
            SavingAccount saving = new SavingAccount(9898,"Husnain Ali",2000,7);
            saving.Deposit(100);
            saving.Withdraw(50);
            bank.AddAccount(saving);


            CheckingAccount check = new CheckingAccount(8989,"Ali Akbar",4000);
            check.Deposit(300);
            bank.AddAccount(check);

            LoanAccount loan = new LoanAccount(9090,"Ali",500,4);
            loan.Deposit(500);
            bank.AddAccount(loan);
            BankAccount account = bank.GetAccount(9898);
            if(account != null)
            {
                account.PrintStatement();
            }
           
            Console.ReadKey();
        }
        
    }
}
