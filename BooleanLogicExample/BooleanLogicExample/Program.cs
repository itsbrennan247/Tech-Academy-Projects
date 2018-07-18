using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please write TRUE or FALSE.");
            String dui = Console.ReadLine();
           
            
            int tickets;
            Console.WriteLine("How many speeding tickets do you have?");
            tickets = Convert.ToInt32(Console.ReadLine());

            if ((age > 15) && (tickets < 3) && (dui == "false"))
            {
                Console.WriteLine("Congrats you qualify!");
            }
            else
            {
                Console.WriteLine("Sorry you do not qualify!");
            }
            Console.ReadLine();
        }
    }
}
