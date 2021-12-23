using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmentOptional
{
    public class Param
    {
        public int reward(int age, int points = 0) //two parameters, points optional
        {
            int result = age * 200;
            if (points != 0)
            {
                result += points;
            }
            return result; //return math operation
        }

        public int age { get; }
        public int points { get; }
    }
}
