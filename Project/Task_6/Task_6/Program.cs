using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence");
            Console.WriteLine("");
            string line=Console.ReadLine();
            Console.WriteLine("");
            string[] Sentense = line.Split(' ');
            string word = null;

            for(int i=0;i<=line.Length;i++)
            {
                if (Sentense[i] == line )
                {
                    word += Sentense[i];
                }
            }
            Console.WriteLine(word);

        }
    }
}
