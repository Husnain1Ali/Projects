using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    public int Account_No;
    public string Account_Holder_Name;
    public decimal Balance;

    public BankAccount(int Account_No, string Account_Holder_Name, decimal Balance)
    {
        this.Account_No = Account_No;
        this.Account_Holder_Name = Account_Holder_Name;
        this.Balance = Balance;
    }
    public virtual void Deposit(decimal amount)
    {
        
        Balance += amount;
    }
    public virtual void Withdraw(decimal amount)
    {
        if(Balance >= amount) 
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Please recharge");
        }
    }
    public void DisplayAccountInfo()
    {
        Console.WriteLine($" Account Number is {Account_No}");
        Console.WriteLine($" Account Holder  is {Account_Holder_Name}");
        Console.WriteLine($" Account Balance is {Balance}");

    }

}

public class SavingsAccount : BankAccount
{
    public decimal interest_rate;
    public SavingsAccount(int Account_No, string Account_Holder_Name, int Balance, decimal interest_rate) : base(Account_No, Account_Holder_Name, Balance)
    {
        this.interest_rate = interest_rate;
    }
    public override void Deposit(decimal amount)
    {
        decimal interest = interest_rate * amount;
        amount = amount + interest;
        base.Deposit(amount);

    }
}
public class CheckingAccount : BankAccount
{
    public CheckingAccount(int Account_No, string Account_Holder_Name, decimal Balance) : base (Account_No, Account_Holder_Name, Balance)
        {

        }

    public override void Withdraw(decimal amount) 
    { 
        if(Balance <= amount) 
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Limit Exceeded");
        }
    
    }
}

public class Bank
{
    public List<BankAccount> accounts;
    public Bank()
    {
        accounts = new List<BankAccount>();
    }

    public void AddAccount(BankAccount account) 
    {
         accounts.Add(account);
    }
    public void DepositToAccount( int Account_No, decimal amount)
    {

        BankAccount account = Get_Number(Account_No);
        {
            if(account != null) 
            {
                account.Deposit(amount);
            }
        }
    }
    public void WithDrawFromAccount(int Account_No, decimal amount)
    {
        BankAccount account = Get_Number(Account_No);
        if(account !=null)
        {
            account.Withdraw(amount);
            Console.WriteLine($"deposite {amount}");
        }
    }
    public BankAccount Get_Number(int Account_No)
    {
        foreach(BankAccount account in accounts)
        {
            if(Account_No == account.Account_No)
                return account;
        }
        return null;
    }
}




namespace A_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank Bank = new Bank();

            SavingsAccount saving = new SavingsAccount(6767, "Ali",1000,7);
            CheckingAccount checking = new CheckingAccount(7878,"Husnain",400);
            Bank.AddAccount(saving);
            Bank.AddAccount(checking);

            Bank.DepositToAccount(6767, 300);
            Bank.WithDrawFromAccount(6767,300);

            Bank.DepositToAccount(7878,700);
            Bank.WithDrawFromAccount(7878,300);

            saving.DisplayAccountInfo();
            checking.DisplayAccountInfo();

            Console.ReadKey();
        }
            
    }
}
