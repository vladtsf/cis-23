using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.RandomWalker.JavaWay;

namespace Lab3.RandomWalker.CSharpWay
{
    class RandomWalkerObserver : JavaWay.RandomWalkerObserver
    {
        public void Moved(StepEventArgs e)
        {
            RandomWalkEvent evt = new JavaWay.RandomWalkEvent((RandomWalkEvent.Directions)e.Direction, e.Walker);
            Moved(evt);
        }
    }
}
