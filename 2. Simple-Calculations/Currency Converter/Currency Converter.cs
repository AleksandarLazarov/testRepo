using System;

public class Currency_Converter
{
    public static void Main(string[] args)
    {
        double num = double.Parse(Console.ReadLine());
        var first = Console.ReadLine().ToLower();//ToLower -ïðàâè òåêñòà â ìàëêè áóêâè
        var second = Console.ReadLine().ToLower();

        if (first == "usd")
        {
            if (second == "bgn")
            {
                Console.WriteLine("{0} BGN", Math.Round(num * 1.79549, 2));
            }
            else if (second == "eur")
            {
                Console.WriteLine("{0} EUR", Math.Round(num * 0.91801, 2));
            }
            else if (second == "gbp")
            {
                Console.WriteLine("{0} GBP", Math.Round(num * 0.70854, 2));
            }

        }

        if (first == "bgn")
        {
            if (second == "usd")
            {
                Console.WriteLine("{0} USD", Math.Round(num / 1.79549, 2));
            }
            else if (second == "eur")
            {
                Console.WriteLine("{0} EUR", Math.Round(num / 1.95583, 2));
            }
            else if (second == "gbp")
            {
                Console.WriteLine("{0} GBP", Math.Round(num / 2.53405, 2));
            }
        }

        if (first == "eur")
        {
            if (second == "bgn")
            {
                Console.WriteLine("{0} BGN", Math.Round(num * 2.53405, 2));
            }
            else if (second == "usd")
            {
                Console.WriteLine("{0} USD", Math.Round(num * 1.08930, 2));
            }
            else if (second == "gbp")
            {
                Console.WriteLine("{0} GBP", Math.Round(num * 0.77181, 2));
            }
        }
        if (first == "gbp")
            if (second == "bgn")
            {
                Console.WriteLine("{0} BGN", Math.Round(num * 0.39462, 2));
            }
            else if (second == "usd")
            {
                Console.WriteLine("{0} USD", Math.Round(num * 2.53405 / 1.79549, 2));//Òóêà áåøå ðàçëèêàòà.
            }
            else if (second == "eur")
            {
                Console.WriteLine("{0} EUR", Math.Round(num * 0.77181, 2));
            }
    }
}

