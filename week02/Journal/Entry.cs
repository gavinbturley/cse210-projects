public class Entry
{
    public string _entry;
    public string _date;
    public string _prompt;
    public void Display()
    {
        Console.WriteLine($"{_date}, {_entry}");
    }
}