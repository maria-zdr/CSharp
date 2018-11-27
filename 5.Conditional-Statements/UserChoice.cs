//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.

using System;

class UserChoice
{
    static void Main()
    {
        Console.Write("Enter 0 for int, 1 - double, 2 - string: ");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 0:
                Console.Write("Enter your int variable: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n + 1);
                break;
            case 1: 
                Console.Write("Enter your double variable: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine(d + 1);
                break;
            default: 
                Console.Write("Enter your string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
        }
    }
}
