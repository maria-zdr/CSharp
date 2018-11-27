//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumbers
{
    static void Main()
    {
        for (int n = 2; n < 100; n++)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) 
            {
                Console.WriteLine("{0} is prime",n);
            }
        }
    }
}

