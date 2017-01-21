using System;

public class Program
{
    public static void Main()
    {
        double angle = double.Parse(Console.ReadLine());
        double radians = angle * (180.0 / Math.PI);
        Console.WriteLine(Math.Round(radians));
    }
}