using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class BankAccount
    {
        private decimal AccountNumber;
        private string Account_Holder_Name;
        private decimal Balance;
        List<Transaction> transactions;
        public BankAccount(decimal AccountNumber, string Account_Holder_Name, decimal Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Account_Holder_Name = Account_Holder_Name;
            this.Balance = Balance;
           
           transactions= new List<Transaction>();
        }
        public decimal GetAccountNumber()
        {
            return AccountNumber;
        }
        public String Get_Account_Holder_Name()
        {
            return Account_Holder_Name;
        }
        public decimal Get_Balance()
        {
            return Balance;
        }
        public void Set_Balance(decimal balance)
        {
            Balance = balance;
        }


        public void Deposit(decimal amount)                                                      // Deposit function and passing parameter name as amount
        {
            Console.WriteLine($"The Balance is {Get_Balance()}");

            decimal balance = Get_Balance() + amount;                                                                          // adding deposited amount in balance
            Set_Balance(balance);
            Console.WriteLine($"The {amount} is added and new balance is {Get_Balance()}");
            Console.WriteLine("");

        }


        public virtual void Withdraw(decimal amount)                                                   // Defining WithDraw function and passing parameter
        {
            if (Balance >= amount)                                                                    // checking if the amount is less than balance then subtract amount from balance in next line
            {
                Balance -= amount;

            }
            else                                                                                      // if amount is greatter than balance print else condition
            {
                Console.WriteLine("Please recharge");
            }
        }

        public void PrintStatement()
        {
            Console.WriteLine("Statement for Account Number: {0}", AccountNumber);
            Console.WriteLine("Account Holder: {0}", Account_Holder_Name);
            Console.WriteLine("Current Balance: {0:C}", Balance);
            Console.WriteLine("Transaction History:");
            foreach (Transaction transaction in transactions)
            {
                transaction.PrintTransaction();
            }
        }


        public abstract void CalculateInterest(decimal amount);

    }


}
