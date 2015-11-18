using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.RandomWalker.CSharpWay
{
    public class StepEventArgs : EventArgs
    {
        public Directions Direction { get; private set; }
        public RandomWalker Walker { get; private set; }

        public enum Directions : int
        {
            LEFT = -1,
            RIGHT = 1
        }

        public StepEventArgs(Directions direction, RandomWalker walker)
        {
            Direction = direction;
            Walker = walker;
        }
    }
}
