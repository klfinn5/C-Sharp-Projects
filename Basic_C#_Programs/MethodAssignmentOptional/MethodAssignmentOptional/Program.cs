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
            
            Param moreMath = new Param(); //instantiate
            //create variables
            int b;
            int z;

            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine()); //user input

            Console.WriteLine("Please enter another number. (Optional: Can leave blank.)"); //option user input
            int num2;

            //allows no user input to be accepted
            if (int.TryParse(Console.ReadLine(), out num2)) 
            {
                Console.WriteLine("Your total reward points are:");
                Console.WriteLine(b = moreMath.reward(num1, num2)); //if user input
            }
            else
            {
                Console.WriteLine("Your total reward points are:");
                Console.WriteLine(z = moreMath.reward(num1, num2)); //if no user input
            }

            Console.ReadLine();

            
        }

       



    }
}


//Console.WriteLine("Please enter a number.");
//int num1 = Convert.ToInt32(Console.ReadLine()); //user input
//Console.WriteLine("Please enter another number. (Optional: Can leave blank.)");
//int num2 = Convert.ToInt32(Console.ReadLine()); //optional user input

//int z;
//Param moreMath = new Param();

//z = moreMath.reward(num1, num2);



//Console.WriteLine("Your total points are " + z);
//Console.ReadLine();
