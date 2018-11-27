//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first integer number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer number: ");
        int b = int.Parse(Console.ReadLine());

        int greater = Math.Max(a, b);
        Console.WriteLine("The greater number is: {0}", greater);
    }
}