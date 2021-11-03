using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_DR.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            //greeting
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();

            //report
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.ReadLine();

            //course
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.ReadLine();

            //page
            Console.WriteLine("What page are you on?");
            string pgNum = Console.ReadLine();
            int page = Convert.ToInt32(pgNum);
            Console.ReadLine();

            //help
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool help = Convert.ToBoolean(Console.ReadLine());

            //experience
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string exp = Console.ReadLine();
            Console.ReadLine();

            //feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feed = Console.ReadLine();
            Console.ReadLine();

            //hours
            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();
            int hours = Convert.ToInt32(yourHours);
            Console.ReadLine();

            //print
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
