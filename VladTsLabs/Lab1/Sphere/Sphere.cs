using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Sphere
    {
        private int x, y, z, radius;

        public Sphere(int x, int y, int z, int radius)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Radius = radius;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Volume() 
        {
            return 4 * Math.PI * Math.Pow(Radius, 3) / 3;
        }

        public double SurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }
    }
}
