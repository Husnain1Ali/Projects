using System;
using System.Collections.Generic;


public class BankAccount
{
    public int Account_No;
    public string Acoount_Holder_Name;
    public int Balance;
    
    public BankAccount(int account_no, string acoount_Holder_Name, int balance)
    {   Account_No = account_no;
        Acoount_Holder_Name = acoount_Holder_Name;
        Balance = balance;
        
    }
    public virtual void Desposit_Money()
    {
        
        Console.WriteLine($"The Account number {Account_No} whose owner name is {Acoount_Holder_Name} deposit money");
    }
    public virtual void WithDraw_Moneny()
    {
        Console.WriteLine($"The Account number {Account_No} whose owner name is {Acoount_Holder_Name} WithraW_Money money");
    }
    public virtual void Display_Infomation()
    {
        Console.WriteLine($"The Account number {Account_No} whose owner name is {Acoount_Holder_Name} has balance {Balance}");
    }
}

public class Saving_Account:BankAccount
{
    public Saving_Account(int account_no, string account_Holder_Name, int balance ,int interest_rate) : base(account_no, account_Holder_Name, balance)
    {
    }

    public override void Desposit_Money()
    {
        int interest;
        
        int Deposite;
        interest = (Deposite / Balance) * 100;
        Balance += interest;
        Console.WriteLine($"The balance aftert interest is {Balance}");
    }

}








namespace aSS_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
