using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many Ewoks live on Endor?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool ewok = false; 
            while (!ewok)
            {
                switch (number) //used to check values
                {
                    case 30000000:
                        Console.WriteLine("You are correct!");
                        ewok = true; //flagging so it knows its correct
                        break;
                    default:
                        Console.WriteLine("Sorry, try again :(");
                        Console.WriteLine("How many Ewoks live on Endor?"); //will restate question
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            Console.WriteLine("How many cups in a gallon?");
            int cups = Convert.ToInt32(Console.ReadLine());
            bool answer = true; //correct answer

            do //actually perform loop
            {
                switch (cups) //used to check values
                {
                    case 16:
                        Console.WriteLine("Correct! :)");
                        answer = false; //flagging so it knows its correct
                        break;
                    default:
                        Console.WriteLine("Sorry, try again :(");
                        Console.WriteLine("How many cups in a gallon?"); //will restate question
                        cups = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (answer); //keep loop going can make it actually keep going *forever*
            Console.Read();


        }
    }
}
