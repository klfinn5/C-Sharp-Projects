using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssign.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gecko Insurance Qualify Now!");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int age = Convert.ToInt32(yourAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? True or False");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int tckt = Convert.ToInt32(tickets);
            Console.ReadLine();

            Console.WriteLine("Qualifed?");
            bool qualify = (age > 15 && dui && tckt <= 3);
            Console.WriteLine("Qualified");
            Console.ReadLine();


        }
    }
}
