using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        // Console.WriteLine("Welcome to the Scripture Memorizer.");
        // Console.WriteLine("Please enter the reference for the scripture you want to memorize in the format 'Book Chapter:Verse");
        // string reference =Console.ReadLine();
        // Console.WriteLine("Please enter the scripture text you want to memorize.");
        // string text = Console.ReadLine();
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine($"{reference.GetDisplayText()}, {scripture.GetDisplayText()}");
            Console.WriteLine("Press enter to hide a random word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;            
            scripture.HideRandomWords(1);
        }
        Console.Clear();
        Console.WriteLine($"{reference.GetDisplayText()}, {scripture.GetDisplayText()}");
        Console.WriteLine("Congrats! You've memorized the scripture!");
        }
}