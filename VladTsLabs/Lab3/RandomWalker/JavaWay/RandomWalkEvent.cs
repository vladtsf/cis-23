using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.RandomWalker.JavaWay
{
    public struct RandomWalkEvent
    {
        public enum Directions : int {
            LEFT = -1,
            RIGHT = 1
        }

        public Directions Direction { get; private set; }
        public RandomWalker Walker { get; private set; }

        public RandomWalkEvent(Directions direction, RandomWalker walker) : this()
        {
            Direction = direction;
            Walker = walker;
        }
    }
}
