using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");

            //Person 1 Info
            int person1hr = 15;
            int person1hw = 40;
            int person1sal = person1hr * person1hw;

            Console.WriteLine("Hourly rate? " + person1hr);
            Console.WriteLine("Hours worked per week? " + person1hw);
            Console.ReadLine();

            //Person 2 Info
            int person2hr = 20;
            int person2hw = 40;
            int person2sal = person2hr * person2hw;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate? " + person2hr);
            Console.WriteLine("Hours worked per week? " + person2hw);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1: " + person1sal);
            Console.WriteLine("Annual salary of Person 2: " + person2sal);
            Console.ReadLine();

            bool moreOrLess = person1sal > person2sal;

            Console.WriteLine("Does Person 1 make more money than Person 2? " + moreOrLess);
            Console.ReadLine();
        }
    }
}
