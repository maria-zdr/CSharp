//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleSurface
{
    static void Main()
    {
        Console.Write("Enter a width: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter a height: ");
        double y = double.Parse(Console.ReadLine());

        double surface = x * y;
        Console.WriteLine("Rectangle's surface is: {0}", surface);
    }
}
