using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to do this activity for (in seconds)?");
        string input = Console.ReadLine();
        if (int.Parse(input) >= 0)
        {
            _duration = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Please enter a valid number of seconds.");
        }
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Congratulations! You have completed {_duration} seconds of the {_name} activity!");
    }
    public void Loading(int seconds)
    {
        for (int i = 0; i < (seconds)/3; i++)
        {
            Console.WriteLine("Loading.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Loading..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public int GetDuration()
    {
        return _duration;
    }
}

public class BreathingActivity : Activity
{
public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Thread.Sleep(3000);
        Console.Clear();
        Loading(6);
        int duration = GetDuration();
        double seconds = double.Parse(duration.ToString());
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
        Console.Clear();
        Console.WriteLine("Breathe in...");
        ShowCountdown(4);
        Console.Clear();
        Console.WriteLine("Breathe out...");
        ShowCountdown(4);
        }
        DisplayEndMessage();
        Thread.Sleep(2000);
    }
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        Activity activity = new Activity(name, description, duration);
    }
}

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are you thankful for?",
        "How has God blessed you today?",
        "How have you seen the hand of God in your life this week?"
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        Activity activity = new Activity(name, description, duration);
    }
    public void Run()
    {
        Console.Clear();
        Loading(6);
        Console.Clear();
        DisplayStartingMessage();
        Thread.Sleep(2000);
        Console.Clear();
        GetRandomPrompt();
        Console.WriteLine("Please enter anything that comes to mind.");
        ShowCountdown(5);
        int duration = GetDuration();
        double seconds = double.Parse(duration.ToString());
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        }
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndMessage();
        Thread.Sleep(2000);
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"{_prompts[index]}");
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        string userInput = Console.ReadLine();
        userList.Add(userInput);
        return userList;
    }
}

public class ReflectionActivity : Activity
{
    private List<string> _prompts =  new List<string>
    {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless.",
        "Think of a time when you did something that you're proud of.",
        "Think of a time when you helped a loved one."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What would you do differently if you could do it again?",
        "How do you think this experience affected those around you"
    };
    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        Activity activity = new Activity(name, description, duration);
    }
    public void Run()
    {
        Console.Clear();
        Loading(6);
        Console.Clear();
        DisplayStartingMessage();
        Thread.Sleep(3000);
        Console.Clear();
        DisplayPrompt();
        Console.WriteLine("\n");
        int duration = GetDuration();
        double seconds = double.Parse(duration.ToString());
        DateTime endTime = DateTime.Now.AddSeconds(seconds + 5);
        Console.WriteLine("Reflect on the following questions as you think about the prompt:");
        ShowCountdown(4);
        while (DateTime.Now < endTime)
        {
        Console.WriteLine("\n");
        DisplayQuestions();
        ShowSpinner(4);
        }
        DisplayEndMessage();
        Thread.Sleep(3000);
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}
public class PatienceActivity : Activity
{
    public PatienceActivity(string name, string description, int duration) : base(name, description, duration)
    {
        Activity activity = new Activity(name, description, duration);
    }

    public void Run()
    {
        Console.Clear();
        Loading(6);
        Console.Clear();
        DisplayStartingMessage();
        Thread.Sleep(3000);
        Console.Clear();
        int duration = GetDuration();
        double seconds = double.Parse(duration.ToString());
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        DisplayPatienceMessage(duration/5);
        Console.Clear();
        DisplayEndMessage();
        Thread.Sleep(2000);
    }

    public void DisplayPatienceMessage(int duration)
    {
        int count = duration * 1000;
        Console.Write("This ");
        Thread.Sleep(count);
        Console.Write("activity ");
        Thread.Sleep(count);
        Console.Write("is ");
        Thread.Sleep(count);
        Console.Write("almost ");
        Thread.Sleep(count);
        Console.Write("done.");
        Thread.Sleep(count);
    }
}