using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_version_3
{
    public interface ITransaction
    {
        void ExecuteTransaction(decimal amount);
        void PrintTransaction(decimal amount);
    }



    public abstract class BankAccount
    {
        private int AccountNumber;
        private string Account_Holder_Name;
        private decimal Balance;

        public BankAccount(int AccountNumber, string Account_Holder_Name, decimal Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Account_Holder_Name = Account_Holder_Name;
            this.Balance = Balance;
        }
        public int GetAccountNumber()
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

        
        public abstract void CalculateInterest(decimal amount);




       

        public void Deposit(decimal amount)                                                      // Deposit function and passing parameter name as amount
        {
            Console.WriteLine($"The Balance is {Get_Balance()}");

            decimal balance = Get_Balance() + amount;                                                                          // adding deposited amount in balance
            Set_Balance(balance);
            Console.WriteLine($"The {amount} is added and new balance is {Get_Balance()}");
            Console.WriteLine("");

        }




        public void Deposit()                                                      // Deposit function and passing parameter name as amount
        {
            Console.WriteLine("Enter the amount you want to deposit");
            decimal interest_rate = 3;
            decimal amount = decimal.Parse(Console.ReadLine());

            decimal interest = amount * interest_rate;
            amount = amount + interest;

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

        public void Withdraw()
        {
            Console.WriteLine("Enter amount you want to withdraw");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Limit Exceeded");                                          //if balance is less than the widdrawl account print else condition
            }
        }



    }


    public class SavingAccount : BankAccount
    {
        decimal interest_rate;


        public SavingAccount(int Account_No, string Account_Holder_Name, int Balance, decimal interest_rate) : base(Account_No, Account_Holder_Name, Balance)                   //Making Constructor and adding one new parameter
        {
            
        }
        public override void CalculateInterest(decimal amount)
        {
            decimal interest = amount * interest_rate;
            amount = amount + interest;
            base.Deposit(amount);
        }


        
    }

    public class CheckingAccount : BankAccount
    {
        decimal interest_rate;
        public CheckingAccount(int Account_No, string Account_Holder_Name, decimal Balance, decimal interest_rate) : base(Account_No, Account_Holder_Name, Balance)
        {
            this.interest_rate = interest_rate;
        }
        public override void CalculateInterest(decimal amount)
        {
            Console.WriteLine("There is no interest in Checking account");
        }


    }

    public class LoanAccount : BankAccount
    {
        public LoanAccount(int Account_No, string Account_Holder_Name, decimal Balance) : base(Account_No, Account_Holder_Name, Balance)
        {

        }
        public override void CalculateInterest(decimal amount)
        {

        }
    }
   



}

