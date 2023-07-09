using System;


namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence");
            Console.WriteLine("");
            string sentence = Console.ReadLine();
            Console.WriteLine("");
            string[] words = sentence.Split(' ');
            

            for (int i = 0; i < words.Length; i++)

            {
                string reverse = null;
                for (int j = words[i].Length; j > 0; j--)
                {
                    reverse += words[i][j-1];
                    
                }
             if(reverse == words[i])
                {
                    Console.WriteLine("palindrome is " + words[i]);
                }
            
            }
            Console.ReadKey();
        }

    }
}
