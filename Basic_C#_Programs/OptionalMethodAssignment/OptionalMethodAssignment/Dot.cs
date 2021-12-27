using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    public class Dot
    {
       
        public int cow(int steak) //int method
        {
            return steak + steak; //addition operation
        }

        public decimal cow(decimal steak) //decimal operation
        {
            return steak; //decimal // cant use matih operations with decimal/double
        }

       public string cow(string steak) //string operations
        {
           try
            {
                
                int result = Int32.Parse(steak); //convert string to int //try to convery string to int
                Console.WriteLine(result - 1); //math operation //perform math operation if possible
            }
            finally //always execute block no matter what
            {
                Console.ReadLine();
            }
            return steak; //return a value
        }

       

    }
}
