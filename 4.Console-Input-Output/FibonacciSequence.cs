//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, …

using System;

class FibonacciSequence
{
    static void Main()
    {
        ulong num1 = 0;
        ulong num2 = 1;
        ulong numNext = 0;
        Console.WriteLine(num1);
        Console.WriteLine(num2);

        for (int i = 0; i < 98; i++)
        {
            numNext = num1 + num2;
            num1 = num2;
            num2 = numNext;
            Console.WriteLine(numNext);
        }
    }
}
