using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Shapes
{
    class Sphere : ThreeDimensionalShape
    {
        public Point Center;
        public double Radius;

        public Sphere(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Center={0} Radius={1} Area={2} Volume={3}", Center, Radius, GetArea(), GetVolume());
        }

        public override double GetArea()
        {
            return 0;
        }

        public override double GetVolume()
        {
            return 0;
        }

        public override void Move(double x, double y, double z)
        {
            Center.Move(x, y, z);
        }
    }
}
