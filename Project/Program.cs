using System;

namespace Task_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                int vowelCount = 0;
                int consonantCount = 0;

                foreach (char letter in word.ToLower())
                {
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        vowelCount++;
                    }
                    else if (char.IsLetter(letter))
                    {
                        consonantCount++;
                    }
                }

                Console.WriteLine("Word: " + word);
                Console.WriteLine("Vowels: " + vowelCount);
                Console.WriteLine("Consonants: " + consonantCount);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
