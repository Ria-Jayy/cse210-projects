using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Creativity:
        // 1. Loads scriptures from a text file.
        // 2. Randomly selects one scripture.
        // 3. Only hides words that are still visible.

        List<Scripture> scriptures = LoadScriptures();

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit': ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Congratulations! You have hidden the entire scripture.");
    }

    static List<Scripture> LoadScriptures()
    {
        List<Scripture> scriptures = new List<Scripture>();

        string[] lines = File.ReadAllLines("scriptures.txt");

        foreach (string line in lines)
        {
            // Skip empty lines
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string[] parts = line.Split('|');

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);

            Reference reference;

            if (parts[3] == "")
            {
                reference = new Reference(book, chapter, verse);
            }
            else
            {
                int endVerse = int.Parse(parts[3]);
                reference = new Reference(book, chapter, verse, endVerse);
            }

            Scripture scripture = new Scripture(reference, parts[4]);
            scriptures.Add(scripture);
        }

        return scriptures;
    }
}