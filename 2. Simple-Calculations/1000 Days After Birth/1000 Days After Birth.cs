using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {

        DateTime result;
        CultureInfo provider = CultureInfo.InvariantCulture;
        var dateString = Console.ReadLine();
        string format = "dd-MM-yyyy";
        result = DateTime.ParseExact(dateString, format, provider);
        DateTime answer = result.AddDays(999);
        Console.WriteLine("{0}", answer.ToString("dd-MM-yyyy"));

    }
}
