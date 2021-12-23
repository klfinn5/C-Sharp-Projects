using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Empty clear = new Empty();  //instantiate

            //declare variables
            int yellow;
            int blue;
            clear.ocean(out yellow, out blue); //passing numbers

            Console.ReadLine();


        }
    }
}
