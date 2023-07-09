using System;

public class HelloWorld
{
    static public void Main()
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