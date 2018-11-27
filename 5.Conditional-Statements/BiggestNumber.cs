//Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestNumber
{
    static void Main()
    {
        int a = 4;
        int b = 8;
        int c = 2;
        int maxNum, minNum, midNum;

        if (a >= b && a >= c) 
        {
            maxNum = a;
        }
        else if (b >= a && b >= c)
        {
            maxNum = b;
        }
        else 
        {
            maxNum = c;
        }
        Console.WriteLine("The max num is {0}", maxNum );
    }
}

