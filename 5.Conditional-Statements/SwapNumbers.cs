//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class SwapNumbers
{
    static void Main()
    {
        int a = 4;
        int b = 2;
        int c;

        if (a > b) 
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("{0},{1}", a, b);
    }
}
