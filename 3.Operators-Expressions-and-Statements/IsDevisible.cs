//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class IsDevisible
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        string numType = (n % 35 == 0) ? "yes" : "no";
        Console.WriteLine("Is {0} devisible by 7 and 5: {1}", n, numType);
    }
}