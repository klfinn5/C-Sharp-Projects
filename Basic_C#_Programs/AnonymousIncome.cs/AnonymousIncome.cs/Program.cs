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
            Console.WriteLine("Hourly Rate? ");
            string hourRate = Console.ReadLine();
            int hr = Convert.ToInt32(hourRate);
            Console.WriteLine("Hours worked per week? ");
            string weekHours = Console.ReadLine();
            int wk = Convert.ToInt32(weekHours);
            Console.ReadLine();

            //person 2 info
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate? ");
            string hourRates = Console.ReadLine();
            int hrs = Convert.ToInt32(hourRates);
            Console.WriteLine("Hours worked per week? ");
            string weekHour = Console.ReadLine();
            int wks = Convert.ToInt32(weekHour);
            Console.ReadLine();

            //salary person 1
            Console.WriteLine("Annual salary of Person 1: ");
            int weeksInYear = 52;
            int salary1 = (hr * wks * weeksInYear);
            Console.WriteLine(salary1);
            Console.ReadLine();

            //salary person 2
            Console.WriteLine("Annual salary of Person 1: ");
            int salary2 = (hrs * wk * weeksInYear);
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
