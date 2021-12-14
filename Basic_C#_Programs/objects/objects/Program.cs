using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objects
{
    class Program
    {
        static void Main(string[] args)

            //exception handlings

        {
            try //try this buuttt
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two..");
                int numberThree = numberOne / numberTwo;
                //concatanated
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) //only catching formatex, ex type of exception
            {
                Console.WriteLine(ex.Message);
                //or our message Console.WriteLine("Please type..");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by 0");
            }
            catch (Exception ex) //general to catch all
            {
                Console.WriteLine(ex.Message);
            }
            finally
            //runs no matter what
            //when you catch something it can stop the code
            {
                Console.ReadLine();
            }
            
        }
    }
}
