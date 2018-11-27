//Write a program that calculates for given N how many trailing zeros present at the end of the number N!

using System;

class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0 ;

        for (int i = 1; i <= n; i++)
        {
            sum += n / (int)Math.Pow(5, i);
        }

        Console.WriteLine("Thw sum is {0}", sum);
    }
}
