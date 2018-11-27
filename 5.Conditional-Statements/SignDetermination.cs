//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class SignDetermination
{
    static void Main()
    {
        Console.Write("Enter firts real number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second real number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third real number: ");
        double c = double.Parse(Console.ReadLine());

        // ordering the elements for easy check later
        double maxNum = Math.Max(Math.Max(a, b), c);
        double minNum = Math.Min(Math.Min(a, b), c);
        double middleNum = a + b + c - maxNum - minNum;

        a = minNum;
        b = middleNum;
        c = maxNum;

        // Console.WriteLine("{0}, {1}, {2}", a, b, c);

        if (a > 0) 
        {
            Console.WriteLine("The sign of the product is \"+\"");
        }
        else if (a < 0 && b > 0) 
        {
            Console.WriteLine("The sign of the product is \"-\"");
        }
        else if (b < 0 && c > 0) 
        {
            Console.WriteLine("The sign of the product is \"+\"");
        }
        else if (c < 0)
        {
            Console.WriteLine("The sign of the product is \"-\"");
        }
        else 
        {
            Console.WriteLine("The result is 0");
        }
    }
}
