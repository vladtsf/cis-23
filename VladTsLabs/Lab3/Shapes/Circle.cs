using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Shapes
{
    class Circle : TwoDimensionalShape
    {
        public Point Center;
        public double Radius;

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Center={0} Radius={1} Area={2}", Center, Radius, GetArea());
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void Move(double x, double y, double z)
        {
            Center.Move(x, y, z);
        }
    }
}
