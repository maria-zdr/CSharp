//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumNNumbers
{
    static void Main()
    {
        Console.Write("Enter the count of the numbers: ");
        int n = int.Parse(Console.ReadLine());
        
        int sum = 0;
        int number;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
