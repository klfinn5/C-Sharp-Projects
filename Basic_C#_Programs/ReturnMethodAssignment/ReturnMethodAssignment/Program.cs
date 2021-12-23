using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths(); //data type then variable

            Console.WriteLine("Enter a number.");
            int sum = Convert.ToInt32(Console.ReadLine()); //user input

            //call methods using user input
            Console.WriteLine(math.Cube(sum)); 
            Console.WriteLine(math.Square(sum));
            Console.WriteLine(math.Add2(sum));
            Console.ReadLine();
        }

       
        
 




    }
}
