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

        Dictionary<decimal,BankAccount> accounts;
            
        public Bank()
        {
            accounts = new Dictionary<decimal, BankAccount>();
        }           

        public void AddAccount(BankAccount Account)
        {
            accounts.Add(Account.GetAccountNumber(), Account);
        }

        public BankAccount GetAccount(decimal Accountnumber)
        {
            if (accounts.ContainsKey(Accountnumber))
            {
                return accounts[Accountnumber];
            }
            return null;
        }


    }
}
