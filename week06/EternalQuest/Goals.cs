public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetPoints()
    {
        return _points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string check;
        if (IsComplete())
        {
            check = "X";
        } else
        {
            check = " ";
        }
        return $"[{check}] {GetShortName()} - {GetDescription()} ({GetPoints()} points)";
    }
    public abstract string GetStringRepresentation();
}

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"{_shortName} completed for {GetPoints()} points!");
        }
        else if (_isComplete)
        {
            Console.WriteLine($"{GetShortName()} is already completed.");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string check;
        if (_isComplete)
        {
            check = "X";
        } else
        {
            check = " ";
        }
        return $"[{check}], {GetShortName()}, {GetDescription()}, ({GetPoints()} points)";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points){}

    public override void RecordEvent()
    {
        Console.WriteLine($"{GetShortName()} completed for {GetPoints()} points!");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{GetShortName()}, {GetDescription()}, ({GetPoints()} points)";
    }
}

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"{GetShortName()} completed for {GetPoints()} points!");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congradulations! You have completed all {_target} tasks for a bonus of {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine($"{GetShortName()} is already completed.");
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return $"[{_amountCompleted}/{_target}] {GetShortName()} - {GetDescription()} ({GetPoints()} points + {_bonus} bonus points)";
    }
    public override string GetStringRepresentation()
    {
        return $"[{_amountCompleted}/{_target}], {GetShortName()}, {GetDescription()}, ({GetPoints()} points, {_bonus} bonus points)";
    }
}
