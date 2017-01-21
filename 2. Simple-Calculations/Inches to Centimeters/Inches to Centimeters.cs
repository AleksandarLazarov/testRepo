using System;

public class Bolnica
{
    public static void Main()
    {
        Console.Write("inches = ");

        double inch = double.Parse(Console.ReadLine());

        double santim = inch * 2.54;


        Console.Write("Centimeters = ");

        Console.WriteLine(santim);

    }
}

