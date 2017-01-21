using System;

public class Program
{
    public static void Main()
    {
        decimal leva = decimal.Parse(Console.ReadLine());
        decimal usd = 1.79549m;
        decimal result = leva * usd;
        Console.WriteLine(Math.Round(result, 2) + " BGN");
    }
}