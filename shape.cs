using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowUp
{
    abstract internal class shape
    {
        public string name;
        public double edge1;
        public string path;

        public shape()
        {
            path = "default.jpg";
        }

        abstract public double Area();
    }
}
