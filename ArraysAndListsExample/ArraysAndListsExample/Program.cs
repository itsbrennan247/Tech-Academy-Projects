using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {
        string[] stringArray = { "Good Morning!", "Good Evening!", "GoodNight!" };

        int[] intArray = { 5, 10, 20, 40, 60, 120, 240, 480 };

        List<string> stringList = new List<string>();
        stringList.Add("Your lucky number is 3!");
        stringList.Add("Your lucky number is 6!");
        stringList.Add("Your lucky number is 9!");
        stringList.Add("Your lucky number is 12!");
        stringList.Add("Your lucky number is 15!");

        int secret;
        Console.WriteLine("Please enter a number between 0-2 to see a hidden message!");
        secret = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringArray[secret]);
        Console.ReadLine();

        int favNum;
        Console.WriteLine("Please enter a number between 0-7 to get a new favorite number!");
        favNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(intArray[favNum]);
        Console.ReadLine();

        int lucky;
        Console.WriteLine("Please enter in a number between 0-4 to get your lucky number for the day!");
        lucky = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringList[lucky]);
        Console.ReadLine();
        }
    }
