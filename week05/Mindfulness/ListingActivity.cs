using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "What made you smile today?"
    };

    Random random = new Random();

    public ListingActivity()
        : base(
            "Listing",
            "List as many positive things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        Console.WriteLine();

        Console.WriteLine("Begin in...");
        ShowCountdown(5);

        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");

        DisplayEndingMessage();
    }
}