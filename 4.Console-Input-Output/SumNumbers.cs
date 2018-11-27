//Write a program that reads 3 integer numbers from the console and prints their sum.
using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("Enter first integer number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third integer number: ");
        int c = int.Parse(Console.ReadLine());

        int sum = a + b + c;
        Console.WriteLine("The sum is: {0}", sum);     
    }
}

