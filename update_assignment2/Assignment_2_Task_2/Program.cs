using System;
using System.Collections.Generic;


public class BankAccount
{
    public int Account_No;
    public string Account_Holder_Name;
    public decimal Balance;

    public BankAccount(int Account_No, string Account_Holder_Name, int Balance)
    {
        this.Account_No = Account_No;
        this.Account_Holder_Name = Account_Holder_Name;
        this.Balance = Balance;

    }
    public virtual void Deposit_Money(decimal amount)
    { 
        amount += Balance;
        
       // Console.WriteLine($"The Account number {Account_No} whose owner name is {Account_Holder_Name} deposit money {Deposit}");
    }

    public virtual void WithDraw_Money(decimal amount)
    {
        if(amount<=Balance)
        {
            amount -= Balance;
        }
        else
        {
            Console.WriteLine("Balance insufficient");
        }
        //Console.WriteLine($"The Account number {Account_No} whose owner name is {Account_Holder_Name} WithraW_Money money");
    }
    public virtual void Display_Infomation()
    {
        Console.WriteLine($"The Account number {Account_No} whose owner name is {Account_Holder_Name} has balance {Balance}");
    }
}

public class Saving_Account : BankAccount
{
   private decimal  interest_rate;
    
    public Saving_Account(int Account_No, string Account_Holder_Name, int Balance, int interest_rate) : base(Account_No, Account_Holder_Name, Balance)
    {
        this.interest_rate = interest_rate;
    }

    public override void Deposit_Money(decimal amount)
    {
        decimal interest=amount*interest_rate;
        Balance = amount + interest;
       
        /* = (Deposit / Balance) * 10;
        Balance += interest;
        Console.WriteLine($"The balance aftert interest is {Balance}"); */
    }

}


public class CheckingAccount : BankAccount
{
    public CheckingAccount(int account_no, string account_Holder_Name, int balance, int interest_rate) : base(account_no, account_Holder_Name, balance)
    {

    }
    public override void WithDraw_Money(decimal amount)
    {
        if (amount <= Balance)
        {
            amount -= Balance;
        }
        else
        {
            Console.WriteLine("Balance insufficient");
        }
    }
    public class Bank
    {
        public List<BankAccount> BankAccounts;

        public Bank()
        {
            BankAccounts = new List<BankAccount>();
        }
        public void AddAccount(BankAccount BankAccount)
        {
            BankAccounts.Add(BankAccount);
            Console.WriteLine($"Account {BankAccount} has been created");
        }

        public void DepositToAccount(int Account_Number, decimal amount)
        {
            BankAccount account = Get_Account_No(Account_Number);
            if (account != null)
            {
                account.Deposit_Money(amount);
            }

        }
        public void WithDrawFromAccount(int Account_No, decimal Amount, decimal Balance)
        {
        }

        public BankAccount Get_Account_No(int Account_No)
        {
            foreach(BankAccount account in BankAccounts)
            {
                if(account.Account_No==Account_Number)
                {
                    return account;
                }

            }
        }
            
      }

}






namespace aSS_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
        }
    }
}