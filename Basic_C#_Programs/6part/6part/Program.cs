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

            //pt1
            List<string> animals = new List<string>() { "Giraffe", "Bat", "Moose" }; //first string
            List<string> userAnimals = new List<string>(); //second string

            Console.WriteLine("Add an animal!");
            string animal = Console.ReadLine();
            animals.Add(animal); //add variable

            foreach (string added in animals) //loop to add second string with var
            {
                Console.WriteLine(added); //var to link
            }
            Console.ReadLine();

            //pt2
            Console.WriteLine("How many pigs hid from the Big Bad Wolf?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool pig = true;
            while (!pig)
            {
                switch (number) //used to check values
                {
                    case 3:
                        Console.WriteLine("You are correct!");
                        pig = true; //correct
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("How many pigs hid from the Big Bad Wolf?"); //will restate question
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                
            }

            //comparison 
            Console.WriteLine("What temperatures are cold?");
            List<int> worldTemp = new List<int>();
            worldTemp.Add(98);
            worldTemp.Add(75);
            worldTemp.Add(112);
            worldTemp.Add(32);
            worldTemp.Add(65);

            foreach (int cold in worldTemp)
            {
                if (cold < 60)
                {
                    Console.WriteLine(cold + " is cold!");
                }
            }
            Console.ReadLine();

            //<= comparison
            Console.WriteLine("Which weights is a healthy weight?");
            List<int> weight = new List<int>();
            weight.Add(115);
            weight.Add(200);
            weight.Add(185);

            foreach (int bf in weight)
            {
                if (bf <= 285)
                {
                    Console.WriteLine(bf + " is a healthy weight!");
                }
            }
            Console.ReadLine();

            //unique string
            List<string> bugs = new List<string>() { "ants", "spiders", "bees", "mantis" };
            Console.WriteLine("What are some cool bugs?");
            string bug = Console.ReadLine();
            
            foreach (string bug in bugs) //loop to add second string with var
            {
                Console.WriteLine(bug); //var to link
            }
            Console.ReadLine();




        }
    }
}
