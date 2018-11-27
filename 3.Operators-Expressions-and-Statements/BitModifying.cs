//We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.

using System;

class BitModifying
{
    static void Main()
    {
        int n = 135;
        int v = 1;
        int p = 4;

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;

        Console.WriteLine(n);
        Console.WriteLine(Convert.ToString(n, 2));
        Console.WriteLine(bit);

        if (bit != v && bit == 0)
        {
            n |= mask;
            Console.WriteLine(n);
            Console.WriteLine(Convert.ToString(n, 2));
        }
        else if (bit != v && bit == 1)
        {
            n &= ~mask;
            Console.WriteLine(n);
            Console.WriteLine(Convert.ToString(n, 2));
        }
        else
        {
            Console.WriteLine(n);
            Console.WriteLine(Convert.ToString(n, 2));
        }
    }
}