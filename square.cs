using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowUp
{
    internal class square:shape
    {
        public double edge2;
        public square()
        {
            path = "hv.jpeg";
        }
        public override double Area()
        {
            return edge1 * edge2;
        }
    }
}
