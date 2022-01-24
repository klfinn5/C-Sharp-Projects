using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboMethodAssignment
{
    public class Classy
    {
        public int meh { get; }

        public void Style(out int meh)
        {
            int result;
            result = meh / 2;
            return;
        }

        public int Yes()
        {
            return meh * meh;
        }


    }
}
