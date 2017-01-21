using System;

public class Program
{

    public static void Main(string[] args)
    {
        double faren;
        double celsius = double.Parse(Console.ReadLine());
        //celsius = int.Parse(Console.ReadLine());
        faren = (celsius * 9) / 5 + 32;
        Console.WriteLine("{0}", Math.Round(faren, 2));

    }
}

