using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Shapes
{
    abstract class ThreeDimensionalShape : Shape
    {
        abstract public double GetArea();
        abstract public double GetVolume();
    }
}
