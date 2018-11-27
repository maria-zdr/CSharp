//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MaxOfNums
{
    static void Main()
    {
        Console.Write("Enter  count of numbers: ");
        int n = int.Parse(Console.ReadLine());
        
        int maxNum = Int32.MinValue;
        int minNum = Int32.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter integer number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > maxNum)
            {
                maxNum = number;
            }

            if (number < minNum)
            {
                minNum = number;
            }
        }
        Console.WriteLine("The max number is {0}", maxNum);
        Console.WriteLine("The min number is {0}", minNum);
    }
}
