using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        string[] teams = { "1", "2", "3", "4", "5" };

        Console.WriteLine("Please enter in 5 of your favorite sports teams!");

        teams[0] = Console.ReadLine();
        teams[1] = Console.ReadLine();
        teams[2] = Console.ReadLine();
        teams[3] = Console.ReadLine();
        teams[4] = Console.ReadLine();

        Console.WriteLine("Here's a list of your favorite teams");
        
        foreach (string team in teams)
        {
            Console.WriteLine(team);
        }
        Console.ReadLine();

        //Loop involving < operator
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine(teams[i]);
        }
        Console.ReadLine();

        //Loop involving <= operator
        for (int i = 0; i <= teams.Length; i++)
        {
            Console.WriteLine(teams[i]);
            return;
        }
        Console.ReadLine();

    }
}
