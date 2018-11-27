//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class SumNumSequence
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {          
            factorial *= i;
            sum += (factorial / Math.Pow(x,i));
        }

        Console.WriteLine("Thw sum is {0}", sum);
    }
}
