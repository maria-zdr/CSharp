//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter x= ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y= ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("Enter height h= ");
        double h = double.Parse(Console.ReadLine());

        double surface = (x + y) / 2 * h;
        Console.WriteLine("Trapezoid's area is: {0}", surface);
    }
}

