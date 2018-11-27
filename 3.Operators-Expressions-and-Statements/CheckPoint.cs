//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class CheckPoint
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        double radius = 5;
        bool isInCircle = (x * x + y * y <= radius * radius) ? true : false;

        Console.WriteLine(isInCircle);
    }
}
