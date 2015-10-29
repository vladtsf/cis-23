using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Shapes
{
    class ShapesTester
    {
        private static List<Shape> shapes;

        public static void RunTests()
        {
            Console.WriteLine("Testing the Shape Hierarchy");

            shapes = new List<Shape> 
            { 
                new Point(0,0,0),
                new Line(new Point(0, 0, 0), new Point(5, 5, 5)),
                new Circle(new Point(0, 0, 0), 3),
                new Sphere(new Point(0, 0, 0), 5)
            };

            PrintShapes();

            Console.WriteLine("Move the shapes");
            foreach (Shape shape in shapes)
            {
                shape.Move(5, 3, 4);
            }

            PrintShapes();
        }

        private static void PrintShapes()
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
