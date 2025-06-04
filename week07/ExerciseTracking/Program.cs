using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<string> activities = new List<string> { };
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Running run = new Running("Running", "05, May, 2025", 30, 10.8);
        activities.Add(run.GetSummary());
        Cycling cycle = new Cycling("Cycling", "06, May, 2025", 45, .5);
        activities.Add(cycle.GetSummary());
        Swimming swim = new Swimming("Swimming", "09, October, 2025", 60, 15);
        activities.Add(swim.GetSummary());
        Stairs stairs = new Stairs("Stairs", "10, uh april, 2025", 75, 10000);
        activities.Add(stairs.GetSummary());
        foreach (string activity in activities)
        {
            Console.WriteLine(activity);
        }
    }
}