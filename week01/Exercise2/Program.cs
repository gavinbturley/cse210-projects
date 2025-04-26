using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letterGrade = "";
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is {letterGrade}.");
        if (grade >= 70) {
            Console.WriteLine("You passed the course, congradulations!");
        }
        else {
            Console.WriteLine("You failed the course, you'll get it next time though!");
        }
    }
}