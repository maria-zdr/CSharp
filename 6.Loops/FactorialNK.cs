using System;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

class FactorialNK
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        if (n > 1 && k > n)
        {
            int factorialK = 1;
            int factorialN = 1;
            int factorialKminN = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            for (int j = 1; j <= k; j++)
            {
                factorialK *= j;
            }

            for (int l = 1; l <= k - n; l++)
			{
			    factorialKminN *= l;
			}

            double result = (factorialN * factorialK) / factorialKminN;
            Console.WriteLine(result);
        }
    }
}
