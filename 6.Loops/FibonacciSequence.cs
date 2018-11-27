//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci

using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        ulong num1 = 0;
        ulong num2 = 1;
        ulong numNext = 0;
        Console.WriteLine(num1);
        Console.WriteLine(num2);

        for (int i = 0; i < n - 2; i++)
        {
            numNext = num1 + num2;
            num1 = num2;
            num2 = numNext;
            Console.WriteLine(numNext);
        }
    }
}
