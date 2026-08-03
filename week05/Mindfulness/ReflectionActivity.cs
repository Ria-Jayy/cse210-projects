using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What made this time different?",
        "What did you learn about yourself?",
        "How can you remember this experience in the future?",
        "How did you feel when it was complete?"
    };

    Random random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity helps you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind press Enter.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}