//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class CheckBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        int p = 3;
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;

        bool isBitZero = (bit == 0) ? true : false;
        Console.WriteLine("Is third bit 0: {0}", isBitZero);
    }
}

