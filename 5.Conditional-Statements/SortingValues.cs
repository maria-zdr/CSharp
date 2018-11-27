//Sort 3 real values in descending order using nested if statements.

using System;

class SortingValues
{
    static void Main()
    {
        Console.Write("Enter firts real number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second real number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third real number: ");
        double c = double.Parse(Console.ReadLine());

        double maxNum, minNum, midNum;

        if (a >= b && a >= c) 
        {
            maxNum = a;
            if (b >= c)
            {
                midNum = b;
                minNum = c;
            }
            else 
            {
                midNum = c;
                minNum = b;
            }
        }
        else if (b >= a && b >= c)
        {
            maxNum = b;
            if (a >= c)
            {
                midNum = a;
                minNum = c;
            }
            else
            {
                midNum = c;
                minNum = a;
            }
        }
        else 
        {
            maxNum = c;
            if (a >= b)
            {
                midNum = a;
                minNum = b;
            }
            else
            {
                midNum = b;
                minNum = a;
            }
        }
        
        Console.WriteLine("Numbers in descending order: {0}, {1}, {2}", maxNum, midNum, minNum );
    }
}
