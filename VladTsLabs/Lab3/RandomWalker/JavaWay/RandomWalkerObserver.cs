using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.RandomWalker.JavaWay
{
    class RandomWalkerObserver : IRandomWalkerObserver
    {
        private uint stepsMade = 0;
        private int rightMostLabel = 0, leftMostLabel = 0;

        private static int[] checkPoints = new int[] {5, 10, 15, 20, 25};

        public void Moved(RandomWalkEvent evt)
        {
            stepsMade++;

            if (evt.Walker.Position > rightMostLabel)
            {
                rightMostLabel = evt.Walker.Position;

                foreach (int point in checkPoints)
                {
                    if (point == evt.Walker.Position)
                    {
                        ReportPoint(point);
                    }
                }
            }
            else if (evt.Walker.Position < leftMostLabel)
            {
                leftMostLabel = evt.Walker.Position;

                foreach (int point in checkPoints)
                {
                    if (-point == evt.Walker.Position)
                    {
                        ReportPoint(-point);
                    }
                }
            }
        }

        private void ReportPoint(int point)
        {
            Console.WriteLine("It took the walker {0} steps to move {1} steps in the {2} direction",
                stepsMade, 
                Math.Abs(point), 
                point > 0 ? "right" : "left");
        }
    }
}
