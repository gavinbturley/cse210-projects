using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Circle circle = new Circle("Green", 2.0);
        Console.WriteLine($"Circle color: {circle.GetColor()}, Area: {circle.GetArea()}");

        Square square = new Square("Blue", 5.0);
        Console.WriteLine($"Square color: {square.GetColor()}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Red", 10.0, 20.0);
        Console.WriteLine($"Rectangle color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");
    }
}