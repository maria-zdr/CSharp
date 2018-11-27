//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumSequence
{
    static void Main()
    {
        int i = 2;
        double sum = 1;
        double sumOld = 0;

        while (Math.Abs(sum - sumOld) >= 0.001)
        {
            sumOld = sum;
            sum = sum + (1 / (double)i) * Math.Pow(-1, i);
            i++;
        }
        Console.WriteLine(sum);
    }
}
