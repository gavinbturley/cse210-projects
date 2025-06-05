using System.Security.Cryptography;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private List<string> _players;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void AddPlayer(string player)
    {
        _players.Add($"{player}, {_score} points");
    }
    public void Start()
    {
        _players = new List<string>();
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest!");
        Console.WriteLine("Please enter your name:");
        string playerName = Console.ReadLine();
        _players.Add($"{playerName}, {_score}");
        bool end = false;
        while (!end)
        {
            Console.Clear();
            Console.WriteLine($"What would you like to do {playerName}?");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record a goal completion");
            Console.WriteLine("3. List goals");
            Console.WriteLine("4. Display player info");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Change player");
            Console.WriteLine("8. Exit");
            string choice = Console.ReadLine();
            Console.Clear();
            if (choice == "1") { CreateGoal(); }
            else if (choice == "2") { RecordEvent(); }
            else if (choice == "3")
            {
                Console.WriteLine("Completion - Goal - Description - Points");
                ListGoalDetails();
            }
            else if (choice == "4") { DisplayPlayerInfo(); }
            else if (choice == "5") { SaveGoals(); }
            else if (choice == "6") { LoadGoals(); }
            else if (choice == "7")
            {
                Start();
            }
            else if (choice == "8")
            {
                end = true;
                Console.WriteLine($"Thank you for playing, {playerName}! Your final score is: {_score}!");
                DisplayPlayerInfo();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        foreach (string player in _players)
        {
            string[] info = player.Split(',');
            string name = info[0];
            Console.WriteLine($"Player: {name} Score: {_score}");
            Thread.Sleep(2000);
        }
    }
    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        int counter = 1;
        foreach (var goal in _goals)
        {

            Console.WriteLine($"{counter}. {goal.GetShortName()}");
            counter++;
        }
    }
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    Thread.Sleep(2000);
    }
    public void CreateGoal()
    {
        Console.WriteLine("What is the name of the goal?");
        string shortName = Console.ReadLine();
        Console.WriteLine("Describe the goal:");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is the goal worth?");
        string points = Console.ReadLine();
        Console.WriteLine("What type of goal? (1) Simple, (2) Eternal, (3) Checklist, (4) Negative");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
            _goals.Add(simpleGoal);
        }
        else if (choice == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == "3")
        {
            Console.WriteLine("How many times is the goal to be completed?");
            string target = Console.ReadLine();
            Console.WriteLine($"How many bonus points are given for completing the goal {target} times?");
            string bonus = Console.ReadLine();
            ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, int.Parse(target), int.Parse(bonus));
            _goals.Add(checklistGoal);
        }
        else if (choice == "4")
        {
            int p = int.Parse(points);
            p = p * -1;
            points = p.ToString();
            NegativeGoal negativeGoal = new NegativeGoal(shortName, description, points);
            _goals.Add(negativeGoal);
        }
        else
        {
            Console.WriteLine("Please input a valid choice");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal have you completed? (Enter a number)");
        ListGoalNames();
        string choice = Console.ReadLine();
        Goal selectedGoal = _goals[int.Parse(choice) - 1];
        selectedGoal.RecordEvent();
        _score += int.Parse(selectedGoal.GetPoints());
        Thread.Sleep(2000);
    }
    public void SaveGoals()
    {
    string filename = "Goals.txt";
        foreach (var goal in _goals)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        string filename = "Goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            // 3 for negative 3 for eternal, 4 for simple, 5 for checklist
            if (parts.Length == 3)
            {
                string shortName = parts[0];
                string description = parts[1];
                string points = parts[2];
                Console.WriteLine($"{shortName} - {description} - {points} points");
                _score += int.Parse(points);
            }
            else if (parts.Length == 4)
            {
                string check = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];
                Console.WriteLine($"{check} {shortName} - {description} - {points} points");
                _score += int.Parse(points);
            }
            else if (parts.Length == 5)
            {
                string amountCompleted = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];
                string bonus = parts[4];
                Console.WriteLine($"{amountCompleted} {shortName} - {description} - {points} points + {bonus} bonus points");
                _score = _score + int.Parse(points) + int.Parse(bonus);
            }
            else
            {
                Console.WriteLine("Invalid goal format in file.");
            }
        }
        Thread.Sleep(2000);
    }
 }