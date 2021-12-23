using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmentOptional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine()); //user input
            Console.WriteLine("Please enter another number. (Optional: Can leave blank.)");
            int num2 = Convert.ToInt32(Console.ReadLine()); //optional user input

            int z;
            Param moreMath = new Param();

            z = moreMath.reward(num1, num2);

            Console.WriteLine("Your total points are " + z);
            Console.ReadLine();

        }

       



    }
}
