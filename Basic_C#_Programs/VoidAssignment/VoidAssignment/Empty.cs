using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidAssignment
{
    class Empty
    {
        public int yellow { get; } 
        public int blue { get; }

        public void ocean(out int yellow, out int blue) //out passes numbers
        {
            yellow = 20 * 2; //math operation
            blue = 50;

            //display 2nd number
            Console.WriteLine(blue);

            //specifying parameters by name
            Console.WriteLine("In ocean, parameter value of blue = {0}", blue);
            Console.WriteLine("In ocean, parameter value of yellow = {0}", yellow);
            return;
        }
    }
}
