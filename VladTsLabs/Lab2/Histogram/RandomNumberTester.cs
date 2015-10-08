using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Histogram
{
    class RandomNumberTester
    {
        public static void RunTests()
        {
            Console.WriteLine("Testing C#'s Random class");
            Test1();
            Console.WriteLine("\n\n");
            Test2();
        }

        public static void Test1()
        {
            Random rnd = new Random();
            Histogram h = new Histogram(10, 0, 1);

            for (int i = 0; i < 10000; i++)
            {
                h.add(rnd.NextDouble());
            }

            Console.WriteLine("Test 1\n");
            Console.WriteLine("Frequency Histogram\n");
            h.plotFrequency();
            Console.WriteLine("\nCumulative Frequency\n");
            h.plotCumulative();
        }

        public static void Test2()
        {
            Random rnd = new Random();
            Histogram h = new Histogram(10, 0, 10);

            for (int i = 0; i < 10000; i++)
            {
                double sum = 0;

                for (int j = 0; j < 10; j++)
                {
                    sum += rnd.NextDouble();
                }

                h.add(sum);
            }

            Console.WriteLine("Test 2\n");
            Console.WriteLine("Frequency Histogram\n");
            h.plotFrequency();
            Console.WriteLine("\nCumulative Frequency\n");
            h.plotCumulative();
        }
    }
}
