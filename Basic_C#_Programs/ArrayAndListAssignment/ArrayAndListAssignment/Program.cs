using System;
using System.Collections.Generic;


namespace ArrayAndListAssignment
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please pick a number between 0 and 6");
            Console.ReadLine();

            string[] weekdays = new string[7];
            weekdays[0] = "Monday";
            weekdays[1] = "Tuesday";
            weekdays[2] = "Wednesday";
            weekdays[3] = "Thursday";
            weekdays[4] = "Friday";
            weekdays[5] = "Saturday";
            weekdays[6] = "Sunday";

            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine(weekdays[i]);
            }
            Console.ReadLine();

            //Console.WriteLine(weekdays[5]);
            //Console.ReadLine();
            
            
            
            
            //Console.WriteLine(weekdays[0]);
            //Console.WriteLine(weekdays[1]);
            //Console.WriteLine(weekdays[2]);
            //Console.WriteLine(weekdays[3]);
            //Console.WriteLine(weekdays[4]);
            //Console.WriteLine(weekdays[5]);
            //Console.WriteLine(weekdays[6]);
            





        }
    }
}
