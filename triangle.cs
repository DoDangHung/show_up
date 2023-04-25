using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowUp
{
    internal class triangle:shape
    {
        public double edge2;
        public triangle()
        {
            path = "tg.png";
        }
        public override double Area()
        {
            return (edge1 * edge2) / 2 ;
        }
    }
}
