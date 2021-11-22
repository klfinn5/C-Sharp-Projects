using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args) //passing a string array
        {

            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            
            ////3 conditions, 1st starting value to 
            ////i is standard but can use any 
            ////length is property of an array
            ////at end of loop it adds 1 to i
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Pass" + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            string[] names = { "Kelsey", "Richard", "Olvie", "Willow" };

            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Kelsey")
                {
                    Console.WriteLine(names[j]);
                }
            }
            Console.ReadLine();



        }
    }
}
