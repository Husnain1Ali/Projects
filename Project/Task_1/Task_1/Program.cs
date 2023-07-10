using System;
using System.Collections.Generic;

namespace SentenceComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i].ToLower();

                if (wordFrequencies.ContainsKey(currentWord))
                {
                    wordFrequencies[currentWord]++;
                }
                else
                {
                    wordFrequencies[currentWord] = 1;
                }
            }

            foreach (var kvp in wordFrequencies)
            {
                Console.WriteLine($"The word '{kvp.Key}' appears {kvp.Value} time(s) in the sentence.");
            }

            Console.ReadLine();
        }
    }
}
