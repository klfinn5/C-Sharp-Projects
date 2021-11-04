using System;
using System.Collections.Generic;


namespace ArrayAndListAssignment
{
    class Program
    {
        static void Main()
        {
            //string array
            Console.WriteLine("Please pick a number between 0 and 6");
            int userIndex = Convert.ToInt32(Console.ReadLine()); //user input

            string[] weekdays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" }; //create string
            //adding elements
            weekdays[0] = "Monday";
            weekdays[1] = "Tuesday";
            weekdays[2] = "Wednesday";
            weekdays[3] = "Thursday";
            weekdays[4] = "Friday";
            weekdays[5] = "Saturday";
            weekdays[6] = "Sunday";

            //error message 
            if (userIndex > 6)
            {
                Console.WriteLine("Doesn't exist");
            }
            Console.ReadLine();

            //user input
            Console.WriteLine(weekdays[userIndex]);
            Console.ReadLine();


            //int array
            Console.WriteLine("Whats your lucky number? Pick between 0 and 3 ");
            int Index = Convert.ToInt32(Console.ReadLine()); //user input

            //adding elements
            int[] lucky = new int[] { 3, 5, 13, 7 }; //create string
            lucky[0] = 3;
            lucky[1] = 5;
            lucky[2] = 13;
            lucky[3] = 7;

            //error message
            if (Index > 3)
            {
                Console.WriteLine("Doesn't exist");
            }
            Console.ReadLine();

            Console.WriteLine(lucky[Index]);
            Console.ReadLine();



            //list
            Console.WriteLine("What is a color that makes purple? Select 0 or 1");
            int indexUser = Convert.ToInt32(Console.ReadLine());
            List<string> colors = new List<string>(1);
            colors.Add("Red");
            colors.Add("Blue");
            Console.WriteLine(colors[indexUser]);
            Console.ReadLine();




        }
    }
}
