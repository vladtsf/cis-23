using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.RandomWalker.CSharpWay
{
    class RandomWalkerTester
    {
        public static void RunTests()
        {
            Console.WriteLine(Environment.NewLine + "Testing RandomWalker (c# way)");
            RandomWalker walker = new RandomWalker();
            RandomWalkerObserver observer = new RandomWalkerObserver();

            walker.OnStepMade += observer.Moved;

            for (int i = 0; i < 100000; i++)
            {
                walker.MakeStep();
            }
        }
    }
}

//Testing RandomWalker(c# way)
//It took the walker 27 steps to move 5 steps in the left direction
//It took the walker 74 steps to move 10 steps in the left direction
//It took the walker 125 steps to move 15 steps in the left direction
//It took the walker 130 steps to move 20 steps in the left direction
//It took the walker 387 steps to move 5 steps in the right direction
//It took the walker 416 steps to move 10 steps in the right direction
//It took the walker 433 steps to move 15 steps in the right direction
//It took the walker 2144 steps to move 20 steps in the right direction
//It took the walker 2281 steps to move 25 steps in the right direction
//It took the walker 2785 steps to move 25 steps in the left direction
