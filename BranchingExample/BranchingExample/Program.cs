using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            string weightTest = weight <= 50 ? "Please enter the package width:" : "Oops! Your package is too heavy to ship!";
            Console.WriteLine(weightTest);
         
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            string dimensionsTest = (height + width + length) > 50 ? "Package is too big to be shipped via Package Express." : "Press enter to figure out your total.";

            Console.WriteLine(dimensionsTest);
            Console.ReadLine();

            int dimensions = height * width * length;

            decimal total = dimensions * weight / 100;
           
            Console.WriteLine("Your estimated total for shipping this package is: $" + total + ".00");
            Console.ReadLine();
            Console.WriteLine("thanks for using Package Express!");
            Console.ReadLine();


        }
    }
}
