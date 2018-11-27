//Write a program to calculate the Nth Catalan number by given N.

using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int factorial2N = 1;
        int factorialN = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            factorial2N *= i;
        }

        for (int j = 1; j <= n; j++)
        {
            factorialN *= j;
        }
        
        double result = factorial2N / ((n+1) * factorialN * factorialN);
        Console.WriteLine(result);
    }
}
