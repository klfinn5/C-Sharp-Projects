﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (weight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                int dimension = (weight + height + length);
                int total = ((weight * height * length * weight) / 100);

                if (dimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else if (dimension <= 50)
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total + ". Thank you!");
                }

            }
            
            Console.ReadLine();
         

        }
    }
}
