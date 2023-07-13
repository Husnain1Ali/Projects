using System;
using System.Collections.Generic;

public interface IBankAccount                                                                                // Creating Interface
{
    void Deposit(decimal amount);                                                                          // Writing signature of Deposit function
    void Withdraw(decimal amount);                                                                        // signature of WithDraw function


}
public abstract class BankAccount : IBankAccount                                                        // Making an abstract class and implements the interface
{
    public int Account_No;
    public string Account_Holder_Name;                                                         // intializing Account Holder name as protected which is only accessible parent and its child
    public decimal Balance;

    public BankAccount(int Account_No, string Account_Holder_Name, decimal Balance)                    // Creating constructor
    {
        this.Account_No = Account_No;                                                                 // Using (this) to use same name of parameters in next classes
        this.Account_Holder_Name = Account_Holder_Name;
        this.Balance = Balance;
    }
    public virtual void Deposit(decimal amount)                                                      // Deposit function and passing parameter name as amount
    {
        Console.WriteLine($"The Balance is {Balance}");

        Balance += amount;                                                                          // adding deposited amount in balance
        Console.WriteLine($"The {amount} is added and new balance is {Balance}");
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

    public abstract void DisplayAccountInfo();                                                   // Making signatureof an abstract method of displayAccountInfo

}

public class SavingsAccount : BankAccount                                                       // making savingAccount child class of BankAccount class
{
    public decimal interest_rate;
    public SavingsAccount(int Account_No, string Account_Holder_Name, int Balance, decimal interest_rate) : base(Account_No, Account_Holder_Name, Balance)                   //Making Constructor and adding one new parameter
    {
        this.interest_rate = interest_rate;
    }
    public override void Deposit(decimal amount)                                             //overriding the deposit method
    {
        decimal interest = interest_rate * amount;
        //amount = amount + interest;                                                         //adding interest in amount
        base.Deposit(amount + interest);

    }
    public override void DisplayAccountInfo()                                               //overriding displayAccountInfo function and display values
    {
        Console.WriteLine($" Account Number is {Account_No}");
        Console.WriteLine($" Account Holder  is {Account_Holder_Name}");
        Console.WriteLine($" Account Balance is {Balance}");

    }
}
public class CheckingAccount : BankAccount                                                // making child class Checking account of parent BankAccount
{
    public CheckingAccount(int Account_No, string Account_Holder_Name, decimal Balance) : base(Account_No, Account_Holder_Name, Balance)
    {

    }

    public override void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Limit Exceeded");                                          //if balance is less than the widdrawl account print else condition
        }
    }
    public override void DisplayAccountInfo()
    {
        Console.WriteLine($" Account Number is {Account_No}");
        Console.WriteLine($" Account Holder  is {Account_Holder_Name}");
        Console.WriteLine($" Account Balance is {Balance}");

    }
}


public class Bank                                                                    // Making a Bank Class
{
    public List<BankAccount> accounts;                                              // making variable of BankAccount to name as accounts
    public Bank()
    {
        accounts = new List<BankAccount>();                                        // passing value of list of accounts                                      
    }

    public void AddAccount(BankAccount account)                                   // creating AddAccount method
    {
        accounts.Add(account);                                                    // adding a new account in the list
    }
    public void DepositToAccount(int Account_No, decimal amount)                 //Creating method of DepositeToAccount
    {

        BankAccount account = Get_Number(Account_No);                           // getthing matched account number from Get_Number method

        if (account != null)
        {
            account.Deposit(amount);                                            // deposirting amount to account 
        }

    }
    public void WithDrawFromAccount(int Account_No, decimal amount)             // method of withdraw amount
    {
        BankAccount account = Get_Number(Account_No);
        if (account != null)
        {
            account.Withdraw(amount);                                         // withdraw amount from account

        }
    }
    public BankAccount Get_Number(int Account_No)                            // making method of Get_Number and using user defined datatype and in thhis method we are comparing user given aacount number with list of account numbers
    {
        foreach (BankAccount account in accounts)                            // getting every acccount from list of accounts
        {
            if (Account_No == account.Account_No)                            // if account finds than return account number
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
            Bank Bank = new Bank();                                                               // Creating object of Bank class
            SavingsAccount saving = new SavingsAccount(6767, "Ali", 1000, 7);                     // Passing values to object (saving) of savingAccount class
            CheckingAccount checking = new CheckingAccount(7878, "Husnain", 400);                  // Passing values to object (checking) of checkingAccount class
            Bank.AddAccount(saving);                                                              //adding asaving ccount 
            Bank.AddAccount(checking);                                                            //adding checking ccount 


            Bank.DepositToAccount(6767, 300);                                                    //depositing value to saving account
            Bank.WithDrawFromAccount(6767, 300);                                                 //Withdraw amount from saving account



            Bank.DepositToAccount(7878, 700);                                                    //depositing value to checking account
            Bank.WithDrawFromAccount(7878, 300);                                                  //Withdraw amount from checking account

            Console.WriteLine("");
            Console.WriteLine("Deposite and Withdraw Money from Acount 6767");
            saving.DisplayAccountInfo();
            Console.WriteLine("");
            Console.WriteLine("Deposite and Withdraw Money from Acount 7878");
            checking.DisplayAccountInfo();

            Console.ReadKey();
        }

    }
}