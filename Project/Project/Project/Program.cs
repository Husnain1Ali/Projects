using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shortest_largest();
            repeatation_check();
        }

        static void shortest_largest()
        {
            
            {
                Console.WriteLine("Enter the line");
                string Line = Console.ReadLine();
                string[] words = Line.Split(' ');

                string min = words[0];
                string max = words[0];
                int minLength = min.Length;
                int maxLength = max.Length;

                for (int i = 1; i < words.Length; i++)
                {
                    string word = words[i];
                    int wordLength = word.Length;

                    if (wordLength < minLength)
                    {
                        min = word;
                        minLength = wordLength;
                    }
                    if (wordLength > maxLength)
                    {
                        max = word;
                        maxLength = wordLength;
                    }
                }

                Console.WriteLine("Shortest word(s):");
                foreach (string word in words)
                {
                    if (word.Length == minLength)
                    {
                        Console.WriteLine(word);
                    }
                }


                Console.WriteLine("Largest word(s):");
                foreach (string word in words)
                {
                    if (word.Length == maxLength)
                    {
                        Console.WriteLine(word);
                    }
                }
                Console.ReadKey();
            }
        }


        static void repeatation_check()
        {

            Console.WriteLine("Enter the sentence");
            Console.WriteLine("");
            string sentence = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter the word you want to search in a sentence: ");
            Console.WriteLine("");
            string word = Console.ReadLine();
            Console.WriteLine("");
            string[] sentences = sentence.Split(' ');
            int repeat = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i] == word)
                {
                    repeat = i;
                }

            }
            Console.WriteLine("");
            Console.WriteLine("The Word (" + word + ") Repeated " + repeat + " times ");
            Console.ReadKey();
        }

    }
}

