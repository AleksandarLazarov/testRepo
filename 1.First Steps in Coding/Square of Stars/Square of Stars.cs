using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var star = new String('*', n);
        Console.WriteLine(star);
        for (var i = 0; i < n - 2; i++)
        {
            Console.WriteLine("*" + new String(' ', n - 2) + "*");
        }
        Console.WriteLine(star);
    }
}