using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //and &&
            Console.WriteLine(true && false); //equals false
            Console.WriteLine(true && true); // equals true
            Console.WriteLine(false && false); //equals false
            Console.ReadLine();

            //or ||
            Console.WriteLine(true || true); //true if one value is true
            Console.WriteLine(true || false);
            Console.WriteLine(false || false); 
            Console.ReadLine();

            //equals ==
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);
            Console.ReadLine();

            //not equal !=
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);
            Console.ReadLine();

            //X Or ^   will evaluate to true if one is true but not both
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);
            Console.ReadLine();

        }
    }
}
