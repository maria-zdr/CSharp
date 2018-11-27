//Write an expression that checks for given point (x, y) if it is within the circle K((1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CheckPointCircleAndRect
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        double radius = 3;
        bool isInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= radius * radius ? true : false;
        bool isInRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1)) ? true : false;

        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("The point is in the circle and not in the rectangle");
        }
        else 
        {
            Console.WriteLine("The point is somewhere else.");
        }
    }
}

