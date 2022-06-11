using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Class5
    {
        public double A { get; set; }
        public double B { get; set; }
        public Class5(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Result()
        {
            return A * B;
        }
    }
}
