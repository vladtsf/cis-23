using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.RandomWalker.JavaWay
{
    class RandomWalkerTester
    {
        public static void RunTests()
        {
            Console.WriteLine(Environment.NewLine + "Testing RandomWalker (Java way)");
            RandomWalker walker = new RandomWalker();
            RandomWalkerObserver observer = new RandomWalkerObserver();

            walker.AddObserver(observer);

            for (int i = 0; i < 10000; i++)
            {
                walker.MakeStep();
            }
        }
    }
}

/*
It took the walker 31 steps to move 5 steps in the right direction
It took the walker 46 steps to move 10 steps in the right direction
It took the walker 221 steps to move 5 steps in the left direction
It took the walker 228 steps to move 10 steps in the left direction
It took the walker 271 steps to move 15 steps in the left direction
It took the walker 310 steps to move 20 steps in the left direction
It took the walker 335 steps to move 25 steps in the left direction
It took the walker 2563 steps to move 15 steps in the right direction
It took the walker 2582 steps to move 20 steps in the right direction
It took the walker 2659 steps to move 25 steps in the right direction
*/
