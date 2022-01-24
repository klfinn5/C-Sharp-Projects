using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Classy pizzaz = new Classy();

            Console.WriteLine("Pick a number.");
            int user = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(pizzaz.Style(out user));

            Console.ReadLine();
        }
    }
}
