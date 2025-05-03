using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Runtime.InteropServices;

public class Program
{
    static Journal journal = new Journal();
    static void Main(string[] args)
    {   
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. View journal entries");
            Console.WriteLine("3. Save journal entries to file");
            Console.WriteLine("4. Load journal entries from file");
            Console.WriteLine("5. Clear journal file");
            Console.WriteLine("6. Exit");
            string userChoice = Console.ReadLine();
            if (userChoice == "1"){journalEntry();}
            else if (userChoice == "2"){viewJournalEntries();}
            else if (userChoice == "3"){saveJournalEntries();}
            else if (userChoice == "4"){loadJournalEntries();}
            else if (userChoice == "5"){journal.clearJournalFile();}
            else if (userChoice == "6"){exit = true;}
            }
        
    }
    static void journalEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string entry = Console.ReadLine();
        Entry newEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;
        newEntry._prompt = prompt;
        newEntry._entry = entry;
        journal.AddEntry(newEntry);
    }
    static void viewJournalEntries()
    {
        journal.DisplayAll();
    }
    static void saveJournalEntries()
    {
        journal.SaveToFile("Journal.txt");
    }
    static void loadJournalEntries()
    {
        journal.LoadFromFile("Journal.txt");
    }
}   