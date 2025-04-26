using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        int number = 1;
        List<string> numbers = new List<string>();
        int total = 0;
        int average = 0;
        int largest = 0;
        while (number != 0)
        {
        Console.WriteLine("Enter a number: (type 0 to stop)");
        string num = Console.ReadLine();
        int input = int.Parse(num);
        if (input == 0)
        {
            number = 0;
        }
        
        else
        {
            total += input;
            numbers.Add(num);
        }
        }
        average = total / numbers.Count;
        foreach (string num in numbers)
        {
            int input = int.Parse(num);
            if (input > largest)
            {
                largest = input;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
    }
}