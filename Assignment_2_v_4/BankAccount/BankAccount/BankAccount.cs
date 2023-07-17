using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class BankAccount
    {     /* Here we are intializing an Abstract class ehich is also a base class or Parent class, we use abstraction to hide the unnecessary details from the user. An Absract class has atleast one abstract method and Calaculate interest method 
            is the abstract method in this class. Here we are making the attributes private which confirms Encapsulation here.   */
        private decimal AccountNumber;
        private string Account_Holder_Name;
        private decimal Balance;
        List<Transaction> transactions;                                                             //Here we intialize a list of Transcations 
        public BankAccount(decimal AccountNumber, string Account_Holder_Name, decimal Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Account_Holder_Name = Account_Holder_Name;
            this.Balance = Balance;

            transactions = new List<Transaction>();
        }

        /*  Below we use the Get Set methods because we intialize the variables Account Number, Account_Holder_Nmae and Balance private, so we are unable to access these attributes in child class 
         *  thats why we use Get Method here we need these attribute in child classes and Set method where we need to update the value of attribute in base class.*/
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
        public void Set_Balance(decimal balance)                                        //Here we are using the Set method because we have to update the balance
        {
            Balance = balance;
        }


        public void Deposit(decimal amount)                                                      // Here we are using Deposit method and passing parameter name as amount. We are also updating Balance in this method
        {
            Console.WriteLine(" ");
            Console.WriteLine($"The Balance is {Get_Balance()}");

            decimal balance = Get_Balance() + amount;                                    // getting Balance amount by Get_Balance Method and then adding it with the amount and Set Balance by using Set Balance Method in the next line
            Set_Balance(balance);
            Console.WriteLine($"The {amount} is added and new balance is {Get_Balance()}");
            Console.WriteLine("");

        }


        public virtual void Withdraw(decimal amount)                                                   // Defining WithDraw function and passing parameter
        {
            if (Balance >= amount)                                                                    // checking if the amount is less than balance then subtract amount from balance in next line
            {
                Console.WriteLine($"We withdraw {amount} from {Balance}");
                Console.WriteLine("");
                Balance -= amount;
               

            }
            else                                                                                      // if amount is greatter than balance print else condition
            {
                Console.WriteLine("Please recharge");
            }
        }

        public void PrintStatement()
            /* Here we made a method to print Account Statment in which we are showing account number, Account Holder name and current balance in dollars*/
        {
            Console.WriteLine("Statement for Account Number: {0}", AccountNumber);
            Console.WriteLine("Account Holder: {0}", Account_Holder_Name);
            Console.WriteLine("Current Balance: {0:C}", Balance);

            Console.WriteLine("");
            foreach (Transaction transaction in transactions)
            {
                //Here we are checking tansaction in transaction list if transcation is present in list then print transcation

                transaction.PrintTransaction();
            }
        }


        public abstract void CalculateInterest(decimal amount);                       /*Here we made an Abstract method of calculate Interest which is akso the requirment of Abstract class and
                                                                                       we will ovride this method in child classes which implement the Polymorphism by using method overriding. And we use method
                                                                                        overriding when we need to implement different functionality in different classes but the method required is same.*/ 


    }


}