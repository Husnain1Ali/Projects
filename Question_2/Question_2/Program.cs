using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your Name");                // Here we are asking to user to put his/her name
            string user_name = Console.ReadLine();              // Here we are getting the name a nd assign to variable (user_name)
            Console.WriteLine("Hello, " + user_name);          // Here we concatenate the Hello a nd User name
            Console.ReadKey();                                // Here we are stoping the code
        }
    }
}
