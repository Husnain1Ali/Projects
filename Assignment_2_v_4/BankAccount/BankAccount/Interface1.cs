using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public interface ITransaction
        /* Here we made an interface in which we are declaring two methods and any class can implement these method. But where the interface will or these method will call it is necessary for that class to 
          define these methods */
    {
        void ExecuteTransaction(decimal amount);        
        void PrintTransaction();
    }


}