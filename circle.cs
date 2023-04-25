using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowUp
{
    internal class circle:shape
    {
        public circle()
        {
            path = "hc.jpg";
        }
        public override double Area()
        {
            return Math.PI * edge1 * edge1;
        }


    }
}
