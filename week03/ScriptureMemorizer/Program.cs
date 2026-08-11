using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text =
            "Trust in the Lord with all thine heart and lean not unto thine own understanding. " +
            "In all thy ways acknowledge him and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            Console.Clear();

            scripture.HideRandomWords(3);

            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine();
        Console.WriteLine("Thank you for using the Scripture Memorizer!");
    }
}

/*
 * Creativity / Exceeding Requirements:
 *
 * I exceeded the core requirements by making the program hide only words
 * that have not already been hidden. This prevents the program from
 * randomly selecting the same hidden word again.
 *
 * I also made the program hide three words at a time, which helps the user
 * gradually memorize the scripture instead of hiding too many words at once.
 */