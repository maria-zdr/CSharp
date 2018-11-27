﻿//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CircleCalculations
{
    static void Main()
    {
        Console.Write("Enter the radius: ");
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;           

        Console.WriteLine("The circle perimeter is: {0}, and the area is: {1} ", perimeter, area);
    }
}
