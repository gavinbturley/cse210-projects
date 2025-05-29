public abstract class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double width) : base(color)
    {
        SetColor(color);
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
      return _length * _width;
    }
}
public class Square : Shape
{
    private double _size;
    public Square(string color, double size) : base(color)
    {
        SetColor(color);
        _size = size;
    }
    public override double GetArea()
    {
        return _size * _size;
    }
}