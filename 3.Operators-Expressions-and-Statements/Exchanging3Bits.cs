using System;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class Exchanging3Bits
{
    static void Main()
    {
        int n = 263146203;        //1111101011110100101011011011

        int mask = 7 << 3;        //111
        int nAndMask = n & mask;
        int firstTriplet = nAndMask >>3;
        mask = ~mask;
        int result = n & mask;

        mask = 7 << 24;
        nAndMask = n & mask;
        int secondTriplet = nAndMask >> 24;
        mask = ~mask;
        result = n & mask;

        //swapping 
        mask = firstTriplet << 24;
        result = result | mask;

        mask = secondTriplet << 3;
        result = result | mask;

        Console.WriteLine(result);  //196037371
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
