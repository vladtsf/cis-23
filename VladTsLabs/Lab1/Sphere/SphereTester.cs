using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SphereTester
    {
        private Sphere Sphere;

        public SphereTester() 
        {
            Sphere = new Sphere(3, 4, 5, 6);    
        }

        public void RunTests() 
        {
            Console.WriteLine("Testing Sphere");

            Console.WriteLine("new Sphere(3, 4, 5, 6)");
            Console.WriteLine("X:" + Sphere.X + ", " + "Y:" + Sphere.Y + ", " + "Z:" + Sphere.Z + ", " + "Radius:" + Sphere.Radius);

            Console.WriteLine("Setting: (X, Y, Z, Radius) to (1,2,3,4)");
            Sphere.X = 1;
            Sphere.Y = 2;
            Sphere.Z = 3;
            Sphere.Radius = 4;
            Console.WriteLine("X: " + Sphere.X + ", " + "Y: " + Sphere.Y + ", " + "Z: " + Sphere.Z + ", " + "Radius: " + Sphere.Radius);

            Console.WriteLine("Volume: " + Sphere.Volume());
            Console.WriteLine("Surface Area: " + Sphere.SurfaceArea());

            Console.WriteLine("Done testing the Sphere class!");
        }
    }
}

/*
Testing Sphere
new Sphere(3, 4, 5, 6)
X:3, Y:4, Z:5, Radius:6
Setting: (X, Y, Z, Radius) to (1,2,3,4)
X: 1, Y: 2, Z: 3, Radius: 4
Volume: 268.082573106329
Surface Area: 201.061929829747
Done testing the Sphere class!
*/