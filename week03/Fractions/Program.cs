using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();

        fraction.setTop(3);
        fraction.setBottom(4);

        int ft = fraction.getTop();
        int fb = fraction.getBottom();

        fraction.getFractionString();
        fraction.getDecimalValue();
    }
}