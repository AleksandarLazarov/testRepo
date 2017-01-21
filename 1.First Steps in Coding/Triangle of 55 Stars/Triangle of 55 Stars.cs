using System;

public class Program
{
    public static void Main()
    {
        for (var i = 1; i <= 10; i++)
        {
            for (var ii = 1; ii <= i; ii++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
    }
}