using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6part
{
    class Program
    {
        static void Main(string[] args)
        {

            //default data is string

            //pt1
            string[] animals = { "Giraffe", "Bat", "Moose" }; //first string, create string array

            Console.WriteLine("Add an animal!");
            string animal = Console.ReadLine(); //value assigned = accessing console = reads what user types = then assigns to variable

            //adding user input will save variables
            for (int i = 0; i < animals.Length; i++) // i targets index of array, length built in to know length of array stop for loop from excutingwhen i is > length array, end of actions in loop add 1 to i
            {
                //Console.WriteLine(animals[i]); //will print original array no edits, take item in array add users input it and save in array, i = index, prints each item, animals array at index i 
                animals[i] = animals[i] + animal; //add user input replaces item in array with new value, reassinging value
                Console.WriteLine(animals[i]); //prints the actual replaced array

            }
            Console.ReadLine();

            //for vs foreach
            //index that targets array is that going to help me or do something to items in array, variable that targets array helps with replacing the value

            //pt2
            int pig = 0;
            while (pig < 10)
            {
                Console.WriteLine(pig);
                pig++; //increment by 1 and fix infinite loop
            }

            //comparison pt3
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //<= comparison
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //unique string pt4
            List<string> bugs = new List<string>() { "ants", "spiders", "bees", "mantis" };
            Console.WriteLine("What are some cool bugs?");
            string bug = Console.ReadLine(); //user value
            bool found = false;

            for (int i = 0; i < bugs.Count; i++) //iterate through list, .count never changes
            {
                if (bug == bugs[i]) //comparion equal = == , checking user input against current list element 
                {
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
            }

            if (!found) //not found
            {
                Console.WriteLine("I didn't find the bug " + bug + ".");
            }
            Console.ReadLine();

            //search lists pt5 want to get to end odf loop so no break duplicate at end 
            List<string> plants = new List<string>() { "pothos", "spider", "snake", "ivy", "ivy" };
            Console.WriteLine("What are some cool plants?");
            string leaf = Console.ReadLine(); //user value
            bool pound = false;

            for (int i = 0; i < plants.Count; i++) //iterate through list, .count never changes
            {
                if (leaf == plants[i]) //comparion equal = == , checking user input against current list element 
                {
                    Console.WriteLine(i);
                    pound = true;
                }

            }
            if (!pound) //not pound
            {
                Console.WriteLine("I didn't find the plant " + leaf + "."); //not in list message
            }
            Console.ReadLine();


            //appeared or not pt6

            var meat = new List<string>() { "Ribeye", "Tenderloin", "Chuck", "Strip", "Strip" };
            Console.WriteLine("Which meats are in stock?");

            var distinct = new HashSet<string>(); //list objects
            var duplicates = new HashSet<string>(); //objects listed more than once

            foreach (var m in meat)
            {
                if (distinct.Add(m))
                {
                    Console.WriteLine(m);
                }
                if (!duplicates.Add(m)) //! makes sure that only the duplicates get this message
                {
                    Console.WriteLine(m + " Already in list");
                }
            }
            Console.ReadLine();


    
            //foreach (string m in meat)
            //{
            //    if (meat.Contains(m))
            //    {
            //        Console.WriteLine(m);
            //    }
            //}
            //Console.ReadLine();






        }
    }
}
