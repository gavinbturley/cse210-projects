using System;

class Program
{
    static void Main(string[] args)
    {
        bool guessed = false;
        Console.WriteLine("Pick a number between 1 and 10: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        while (guessed == false) {
            Console.WriteLine("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            if (guess == number) {
                Console.WriteLine("You guessed it!");
                guessed = true;
                }
            else if (guess < number) {Console.WriteLine("Your guess is too low.");}
            else if (guess > number) {Console.WriteLine("Your guess is too high.");}
            else {Console.WriteLine("Invalid input.");}
        }
    }
}