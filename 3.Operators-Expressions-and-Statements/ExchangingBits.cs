//Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class ExchangingBits
{
    static void Main()
    {
        int n = 263146203;  //1111101011110100101011011011
        int p = 1;          //starting position of first sequence to swap
        int q = 11;          //starting position of second sequence to swap
        int k = 4;          //number of bits to swap

        int result;
        double maskLenght = Math.Pow(2, k) - 1;
        int mask = (int)maskLenght;

        mask = mask << p;       
        int nAndMask = n & mask;
        int firstSeq = nAndMask >> p;
        mask = ~mask;
        result = n & mask;

        mask = (int)maskLenght;
        mask = mask << q;
        nAndMask = n & mask;
        int secondSeq = nAndMask >> q;
        mask = ~mask;
        result = result & mask;

        //swapping
        mask = (int)maskLenght; 
        mask = firstSeq << q;

        result = result | mask;
        mask = (int)maskLenght;
        mask = secondSeq << p;
        result = result | mask;

        Console.WriteLine(result);  
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
