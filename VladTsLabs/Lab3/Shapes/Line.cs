using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Shapes
{
    class Line : OneDimensionalShape
    {
        public Point P1;
        public Point P2;

        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Point1={0} Point2={1} Length={2}", P1, P2, GetLength());
        }

        public override double GetLength()
        {
            return Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2) + Math.Pow(P2.Z - P1.Z, 2));
        }

        public override void Move(double x, double y, double z)
        {
            P1.Move(x, y, z);
            P2.Move(x, y, z);
        }
    }
}
