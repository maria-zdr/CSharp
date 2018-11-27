//Write a program that finds the greatest of given 5 variables.

using System;

class MaxOfFiveNums
{
    static void Main()
    {
        int maxNum=Int32.MinValue;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > maxNum)
            {
               maxNum = number;
            }          
        }
        Console.WriteLine("The max number is {0}", maxNum);
    }
}

