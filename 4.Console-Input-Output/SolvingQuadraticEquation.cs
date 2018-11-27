﻿//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

class SolvingQuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
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
