//Ex. 10 Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. 
//Ex. 11 Write an expression that extracts from a given integer i the value of a given bit number b. 

using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter int number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;

        //Exercises 10
        Console.WriteLine("The bit at position {0} has value 1: {1}", p, bit != 0 ? true : false);

        //Exercises 11 - extracted bit value
        Console.WriteLine(bit);
    }
}