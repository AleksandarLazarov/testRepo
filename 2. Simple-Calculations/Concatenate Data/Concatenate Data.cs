﻿using System;

public class Bolnica
{
    public static void Main()
    {

        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();


        Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);


    }
}

