using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Shapes
{
    class Point : ZeroDimensionalShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" X={0} Y={1} Z={2}", X, Y, Z);
        }

        public override void Move(double x, double y, double z)
        {
            X += x;
            Y += y;
            Z += z;
        }
    }
}
