using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMethodAssignment
{
    public class Maths
    {
        
        //like filling out a form
        public int three { get; } // "form" fields //int can only "get"
        public int two { get; }
        public int one { get; }

        public int Cube(int sum) //constructor needs to go into fields
        {
            return sum * sum * sum;
        }

        public int Square(int sum)
        {
            return sum * sum;
        }

        public int Add2(int sum)
        {
            return sum + 2;
        }
    }
}
