using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //a string is a data type

            string name = "Kelsey";
            //backslash \ means its still part of the string 
            string quote = "She said, \"Tha's what\", Kelsey. \n Hello new line. \n \t Hello on tab";
            string filename = @"C:\\Users\\Kelsey"; //file names need double

            Console.WriteLine(quote);
            Console.ReadLine();

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("s");

            int length = name.Length;

            name = name.ToLower();
            name = name.ToUpper();


            string name = "Kelsey";
            name = "Richard";

            Console.WriteLine(name);
            Console.ReadLine();




            StringBuilder sb = new StringBuilder();
            //dynamic object is expandable without loss of performance

            sb.Append("My name is Kelsey");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
