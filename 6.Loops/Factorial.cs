//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        if (k > 1 && n > k)
        {
            int factorialK = 1;
            int factorialN = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            for (int j = 1; j <= k; j++)
            {
                factorialK *= j;
            }

            double result = factorialN / factorialK;
            Console.WriteLine(result);
        }
    }
}
