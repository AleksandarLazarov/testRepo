using System;

public class Program
{
    public static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double area = 0;
        double perimeter = 0;

        if (x1 > x2 && y1 > y2)
        {
            area = (x1 - x2) * (y1 - y2);
            perimeter = 2 * ((x1 - x2) + (y1 - y2));
        }
        else if (x1 < x2 && y1 < y2)
        {
            area = (x2 - x1) * (y2 - y1);
            perimeter = 2 * ((x2 - x1) + (y2 - y1));
        }
        else if (x1 < x2 && y1 > y2)
        {
            area = (x2 - x1) * (y1 - y2);
            perimeter = 2 * ((x2 - x1) + (y1 - y2));
        }
        else if (x1 > x2 && y1 < y2)
        {
            area = (x1 - x2) * (y2 - y1);
            perimeter = 2 * ((x1 - x2) + (y2 - y1));
        }


        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}