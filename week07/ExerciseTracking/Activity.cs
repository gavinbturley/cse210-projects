public abstract class Activity
{
    protected string _name;
    protected string _date;
    protected int _minutes;
    public Activity(string name, string date, int minutes)
    {
        _name = name;
        _date = date;
        _minutes = minutes;
    }
    public string GetName()
    {
        return _name;
    }
        public string GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public abstract string GetSummary();

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace(); //min per km

}
public class Running : Activity
{
    private double _distance;
    public Running(string name, string date, int minutes, double distance) : base(name, date, minutes)
    {
        _distance = distance;
    }
    public override string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min): Distance {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }//03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km


    public override double GetDistance()
    {
        return (double)_distance;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
    public override double GetPace()
    {
        return (double)_minutes / GetDistance();
    } //min per km
}
public class Cycling : Activity
{
    private double _speed;
    public Cycling(string name, string date, int minutes, double speed) : base(name, date, minutes)
    {
        _speed = speed;
    }
    public override string GetSummary()
    { 
        return $"{_date} {_name} ({_minutes} min): Distance {GetDistance()} km, Speed: {_speed} kph, Pace: {GetPace()} min per km";
    }

    public override double GetDistance()
    {
        return (double)_speed * (_minutes * 60);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return (double)_minutes / GetDistance();
    } //min per km

}
public class Swimming : Activity
{
    private double _laps;
    public Swimming(string name, string date, int minutes, double laps) : base(name, date, minutes)
    {
        _laps = laps;
    }
    public override string GetSummary()
    { 
        return $"{_date} {_name} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

    public override double GetDistance()
    {
        return (double)(_laps * 50 / 1000);
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
    public override double GetPace()
    {
        return (double)_minutes / GetDistance();
    } //min per km

}
public class Stairs : Activity
{
    private double _steps;
    public Stairs(string name, string date, int minutes, double steps) : base(name, date, minutes)
    {
        _steps = steps;
    }
    public override string GetSummary()
    { 
        return $"{_date} {_name} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

    public override double GetDistance()
    {
        return (double)(_steps * 0.3 / 1000);
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
    public override double GetPace()
    {
        return (double)_minutes / GetDistance();
    } //min per km

}