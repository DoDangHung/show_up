using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowUp
{
    internal class Rectangle:shape
    {
        public string picturePath = "hcn.png";
        public double edge2;
        public Rectangle()
        {
            path = "hcn.png";
        }
        public override double Area()
        {
            return edge1 * edge2;
        }
    }
}
