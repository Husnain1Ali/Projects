using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence");
            Console.WriteLine("");
            string sentence = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter the word you want to search in a sentence: " );
            Console.WriteLine("");
            string word = Console.ReadLine();
            Console.WriteLine("");
            string[] sentences = sentence.Split(' ');
            int repeat = 0;
            
            for(int i=0;i<sentences.Length;i++) 
            {
                if (sentences[i] == word)
                {
                    repeat = i;
                }
              
            }
            
            Console.WriteLine("");
            Console.WriteLine("The Word (" + word  +") Repeated "+ repeat +" times ");
            
            Console.ReadKey();

           
           
        }
      
    } 
}
