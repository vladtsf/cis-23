﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes.ShapesTester.RunTests();
            RandomWalker.JavaWay.RandomWalkerTester.RunTests();

            #if DEBUG
                Console.WriteLine();
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            #endif
        }
    }
}
