//Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        double x1, x2, d;

        d = b * b - 4 * a * c;

        if (d > 0)
        {
            x1 = (-b - Math.Sqrt(d)) / (2 * a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("The roots are: {0}, {1}", x1, x2);
        }
        else if (d == 0)
        {
            x1 = -b / (2 * a);
            x2 = -b / (2 * a);
            Console.WriteLine("The roots are equal (x1 = x2): {0}, {1}", x1, x2);
        }
        else
        {
            Console.WriteLine("There are no real roots.");
        }
    }
}
