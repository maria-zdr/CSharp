//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        int gcd;

        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
            gcd = b;
        else
            gcd = a;

        Console.WriteLine("The Greatest Common Divisor is {0}", gcd);
    }
}
