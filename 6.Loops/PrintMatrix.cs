using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n < 20) 
        {
            for (int i = 1; i <= n; i++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("{0} ", i + row);
                }
                Console.WriteLine();
            }
        }
    }
}
