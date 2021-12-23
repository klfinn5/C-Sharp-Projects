using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    public class Dot
    {
        public int four { get; }
        public int five { get; }
        public int six { get; }

       
        public int cow(int user)
        {
            return user + user;
        }

        public double cow(double user)
        {
            double all = user;
            int doub = Convert.ToInt32(all); //convert decimals to int
            return user * 2;
        }

       public string cow(string user)
        {
           try
            {
                
                int result = Int32.Parse(user); //convert string to int
                Console.WriteLine(result - 1); //math operation
            }
            finally
            {
                Console.ReadLine();
            }
            return user; //return a value
        }

       

    }
}
