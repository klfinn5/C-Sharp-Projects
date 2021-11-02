using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //person 1 info
            Console.WriteLine("Person 1");
            int hourRate = 15;
            int weekHours = 40;
            Console.WriteLine("Hourly Rate? " + hourRate);
            Console.WriteLine("Hours worked per week? " + weekHours);
            Console.ReadLine();

            //person 2 info
            Console.WriteLine("Person 2");
            int hourRates = 20;
            int weekHour = 40;
            Console.WriteLine("Hourly Rate? " + hourRates);
            Console.WriteLine("Hours worked per week? " + weekHour);
            Console.ReadLine();

            //salary person 1
            Console.WriteLine("Annual salary of Person 1: ");
            int weeksInYear = 52;
            int salary1 = (hourRate * weekHours * weeksInYear);
            Console.WriteLine(salary1);
            Console.ReadLine();

            //salary person 2
            Console.WriteLine("Annual salary of Person 1: ");
            int salary2 = (hourRates * weekHour * weeksInYear); 
            Console.WriteLine(salary2);
            Console.ReadLine();

            //bool income
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreThan = salary1 > salary2;
            Console.WriteLine(moreThan);
            Console.ReadLine();
        }
    }
}
