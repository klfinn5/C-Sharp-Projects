using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dot farm = new Dot(); //data type and veriable 
            Console.WriteLine("Enter a number, please");

            
            var user = Convert.ToInt32(Console.ReadLine()); //user input
            double all = user;
            int doub = Convert.ToInt32(all); //convert decimals to int

            Console.WriteLine(farm.cow(user));
            Console.ReadLine();
        }




    }
}



//string bleh = user.ToString();
//double all = user;
//int meh = Int32.Parse(bleh);
//int num = Convert.ToInt32(all);