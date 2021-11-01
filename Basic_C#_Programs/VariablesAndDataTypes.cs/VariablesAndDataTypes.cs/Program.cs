using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number is: " + favoriteNumber);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemperature = -23;
            //char questionMark = "\u2013";

            decimal_moneyInTheBank = 100.5m;

            double heightInCentimeters = 34.33434334;

            float secondsLeft = 3.32f;

            short temperatureOnMars = -341;

            string myName = "Kelsey";

            int currentAge = 39;
            string yearsOld = currentAge.ToString();

            bool itsRaining = true;
            string rainingStatus = Convert.ToString(itsRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

        }
    }
}
