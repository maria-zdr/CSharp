//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 ->  1+1-2=0.

using System;

class SubsetSum
{
    static void Main()
    {
        int[] numbers = new int[5];
        int counter = 0;
        for (int n = 0; n < 5; n++)
        {
            numbers[n] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i < 32; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                sum += ((i >> j) & 1) * numbers[j];
            }
            if (sum == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter + " Subset sums = 0"); 
    }
}
