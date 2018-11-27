//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
//Example: p(17,25) = 2.

using System;

class DividedBy5
{
    static void Main()
    {
        Console.Write("Enter first integer number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer number: ");
        int b = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = Math.Min(a, b) ; i <= Math.Max(a, b); i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("Numbers divisible by 5 in the given interval is: {0}", counter);
    }
}
