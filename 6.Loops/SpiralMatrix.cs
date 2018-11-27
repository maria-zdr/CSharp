//Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];

        for (int row = 0, col = n - 1, count = 0; col >= 0; row++, col--) 
        {
            // Printing forward 
            for (int k = row; k < col; k++)
            {
                arr[row, k] = ++count;
            }

            // Printing Downward
            for (int k = row; k < col; k++)
            {
                arr[k, col] = ++count;
            }

            // Printing Backward 
            for (int k = col; k > row; k--)
            {
                arr[col, k] = ++count;
            }

            // Printing Backward
            for (int k = col; k > row; k--)
            {
                arr[k, row] = ++count;
            }

            if (row == col) 
            {
                arr[row, row] = ++count;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 2} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}