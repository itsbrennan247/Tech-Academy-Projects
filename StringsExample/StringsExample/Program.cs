using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Brennan";
            string sen1 = "Hello, my name is " + name + ". ";
            string sen2 = "Here is my name in quotes: \"" + name + ".\" ";
            name = name.ToUpper();
            string sen3 = "Here is my name uppercased: " + name + ".";

            Console.WriteLine(sen1);
            Console.WriteLine(sen2);
            Console.WriteLine(sen3);
            Console.ReadLine();

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("Here is the first sentence of the paragraph. ");
            Console.WriteLine(paragraph);
            Console.ReadLine();
            paragraph.Append("Here is the second sentence of the paragraph. ");
            Console.WriteLine(paragraph);
            Console.ReadLine();
            paragraph.Append("Here is the final sentence of the paragraph!");
            Console.WriteLine(paragraph);
            Console.ReadLine();

            Console.WriteLine(sen1 + sen2 + sen3);
            Console.ReadLine();
        }
    }
}
