using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Shapes
{
    abstract class Shape
    {
        private static int lastId = 0;
        private int ShapeID;

        public Shape() 
        {
            ShapeID = lastId++;
        }

        public int GetID() 
        {
            return ShapeID;
        }

        abstract public void Move(double x, double y, double z);

        public override string ToString()
        {
            return String.Format("Shape: id={0}", ShapeID);
        }
    }
}
