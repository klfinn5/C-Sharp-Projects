using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //addition
            int total = 5 + 10;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.ReadLine();

            //addition with two 
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();

            //subtraction
            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.ReadLine();

            //multiplication
            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            //division
            int quotient = 10 / 5; //double instead of int for decimal
            Console.WriteLine(product);
            Console.ReadLine();

            //remainder
            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            //boolean
            bool trueOrFalse = 12 > 5;
            Console.Write(trueOrFalse.ToString));
            Console.ReadLine();

            //boolean 
            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();







        }
    }
}
