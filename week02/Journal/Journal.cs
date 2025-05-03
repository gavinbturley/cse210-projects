using System.IO; 

public class Journal
{
    public void LoadFromFile(string fileName)
    {
    string filename = "Journal.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
        {
        string[] parts = line.Split(",");
        string date = parts[0];
        string prompt = parts[1];
        string entry = parts[2];
        Console.WriteLine($"{date}, {prompt}, {entry}");
        }
    }
    public void clearJournalFile()
    {
        string fileName = "Journal.txt";
        File.WriteAllText(fileName, string.Empty);
        Console.WriteLine("Journal file cleared.");
    }
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {   
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._prompt}, {entry._entry}");}
            }
        }
    }

