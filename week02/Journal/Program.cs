using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. View journal statistics");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    SaveJournal(journal);
                    break;

                case "4":
                    LoadJournal(journal);
                    break;

                case "5":
                    DisplayStatistics(journal);
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a number from 1 to 6.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine($"\nPrompt: {prompt}");

        Console.Write("Response: ");
        string response = Console.ReadLine();

        Console.Write("How would you describe your mood today? ");
        string mood = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry(date, prompt, response, mood);

        journal.AddEntry(entry);

        Console.WriteLine("Your journal entry has been saved.");
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter the filename you want to save to: ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter the filename you want to load: ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);
    }

    static void DisplayStatistics(Journal journal)
    {
        Console.WriteLine("\n========== JOURNAL STATISTICS ==========");
        Console.WriteLine($"Total journal entries: {journal.GetEntryCount()}");
    }
}

/*
 * Creativity / Exceeding Requirements:
 *
 * I exceeded the core requirements by adding a Mood field to every
 * journal entry. The user can record how they felt when writing the entry.
 *
 * I also added a Journal Statistics option that displays the total number
 * of entries currently stored in the journal. I included more than five
 * original prompts to give the user more variety when journaling.
 */