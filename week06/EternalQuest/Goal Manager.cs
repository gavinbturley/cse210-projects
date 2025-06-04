using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> goals;
    private int _score;
    public GoalManager()
    {
        goals = new List<Goal>();
        _score = 0;
    }
    public void GetList()
    { 
        
    }
    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }
    public void ListGoalDetails()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    { 
        string filename = "Goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            // 3 for eternal, 4 for simple, 5 for checklist
            if (parts.Length == 3)
            {
                string shortName = parts[0];
                string description = parts[1];
                string points = parts[2];
                goals.Add({ shortName, description, points});
            }
            else if (parts.Length == 4)
            {
                string check = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];                
            }
        }
    }
 }