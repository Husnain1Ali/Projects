using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Bank
    {
        //Here we are intializing the Dictionary in which key is datatype of amount and value is BankAccount

        Dictionary<decimal, BankAccount> accounts;

        public Bank()
        {
            accounts = new Dictionary<decimal, BankAccount>();
        }

        public void AddAccount(BankAccount Account)
        {
            /* In this method we adding the account in the accounts which is a dictionary when it is called by main class*/

            accounts.Add(Account.GetAccountNumber(), Account);
        }

        public BankAccount GetAccount(decimal Accountnumber)
        {
            //Here in this method it checks if the Account number given by user is present in the accounts distionary then it returns Account number otherwise return null
            if (accounts.ContainsKey(Accountnumber))
            {
                return accounts[Accountnumber];
            }
            return null;
        }


    }
}