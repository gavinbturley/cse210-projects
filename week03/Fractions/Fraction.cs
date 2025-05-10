public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;    
        _bottom = 1; 
    }

    public int getTop()
    {
        return _top;
    }

    public void setTop(int top)
    {
        _top = top;
    }

    public int getBottom()
    {
        return _bottom;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }
    public void getFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public double getDecimalValue()
    {
        Console.WriteLine($"{(double)_top / _bottom}");
        return (double)_top / _bottom;
    }
}