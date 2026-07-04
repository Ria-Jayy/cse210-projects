using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask for first name
        Console.Write("What is your first name?: ");
        string firstName = Console.ReadLine();

        //Ask for last name
        Console.Write("What is your last name?: ");
        string lastName = Console.ReadLine();

        //Display full name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}