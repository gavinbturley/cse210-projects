using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        int numberBreathing = 0;
        int numberListing = 0;
        int numberReflection = 0;
        int numberPatience = 0;
        bool end = false;
        while (!end)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Patience Activity");
            Console.WriteLine("5. Quit");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by controlling your breathing.", 0);
                breathingActivity.Run();
                numberBreathing++;
            }
            else if (userInput == "2")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                listingActivity.Run();
                numberListing++;
            }
            else if (userInput == "3")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflectionActivity.Run();
                numberReflection++;
            }
            else if (userInput == "4")
            {
                PatienceActivity patienceActivity = new PatienceActivity("Patience Activity", "This activity will help you develop more patience.", 0);
                patienceActivity.Run();
                numberPatience++;
            }
            else if (userInput == "5")
            {
                Console.Clear();
                end = true; 
                Console.WriteLine("Program ended.");
                Console.WriteLine($"You have completed the following activities: \nBreathing Activity: {numberBreathing} times \nListing Activity: {numberListing} times \nReflection Activity: {numberReflection} times \nPatience Activity: {numberPatience} times");
            }
            else
            {
                Console.WriteLine("Please enter 1-4");
            }
        }
    }
}