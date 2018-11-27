//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {      
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
            
        string numType = (n % 2 == 0) ? "even" : "odd";
        Console.WriteLine("{0} is {1}", n, numType);          
    }
}