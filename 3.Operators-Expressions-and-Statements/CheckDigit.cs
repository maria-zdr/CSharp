//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 - true.

using System;

class CheckDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        bool digitCheck = ((n / 100) % 10 == 7) ? true : false;
        Console.WriteLine(digitCheck);
    }
}
