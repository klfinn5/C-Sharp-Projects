using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try this guarded code, executed until exception happens
            {
                List<int> numbers = new List<int>() { 2, 4, 6, 8, 10, 12, 14 };
                Console.WriteLine("What would you like to divide by?");
                int user = Convert.ToInt32(Console.ReadLine()); //user input 

                for (int i = 0; i < numbers.Count; i++) //iterate through list
                {
                    Console.WriteLine(i / user); //divide list by user input
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException ex) //stops code when 0 is entered and generates error message
            {
                Console.WriteLine("Zero is an invalid response.");
            }
            catch (Exception ex) //catches any other exceptions like strings, decimals, etc
            {
                Console.WriteLine("Please try a whole number.");
            }
            finally //executes try block
            {
                Console.ReadLine();
            }


        }
    }
}
