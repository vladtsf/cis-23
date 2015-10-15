using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Histogram
{
    class Histogram
    {
        private int[] counters;
        private double step;
        private double min, max;
        private int n;
        private const int PLOT_WIDTH = 50;

        public Histogram(int n, double min, double max)
        {
            if (min.CompareTo(max) > -1) {
                throw new ArgumentException("the minimum should be less than the maximum");
            }

            this.min = min;
            this.max = max;
            this.n = n;

            step = (max - min) / n;
            reset();
        }

        public Histogram(double min, double max) : this(10, min, max) { }

        public void add(double number)
        {
            if (number.CompareTo(min) == -1 || number.CompareTo(max) > -1) {
                throw new ArgumentOutOfRangeException(String.Format("the number {0} is out of the range [{1},{2})", number, min, max));
            }

            int idx = (int)((number - min) / step);

            counters[idx]++;
        }

        public void reset()
        {
            counters = new int[n];
        }

        private static void plotPoint(int value, int maxCounter) 
        {
            int height = maxCounter > 0 ? (int)(PLOT_WIDTH * value / maxCounter) : 0;

            Console.WriteLine("{0}  {1}", new String('*', height), value);
        }

        public void plotFrequency()
        {
            int maxValue = counters.Max();

            for (int i = 0; i < n; i++)
            {
                plotPoint(counters[i], maxValue);
            }
        }

        public void plotCumulative()
        {
            int sum = 0;
            int maxValue = counters.Sum();

            for (int i = 0; i < n; i++)
            {
                sum += counters[i];
                plotPoint(sum, maxValue);
            }
        }
    }
}

/*
Testing C#'s Random class
Test 1

Frequency Histogram

**********************************************  957
*************************************************  1028
************************************************  1013
************************************************  995
***********************************************  974
************************************************  1004
**************************************************  1036
***********************************************  991
*************************************************  1019
***********************************************  983

Cumulative Frequency

****  957
*********  1985
**************  2998
*******************  3993
************************  4967
*****************************  5971
***********************************  7007
***************************************  7998
*********************************************  9017
**************************************************  10000



Test 2

Frequency Histogram

  0
  0
*  13
*******************  147
**************************************************  372
*********************************************  335
****************  123
*  10
  0
  0

Cumulative Frequency

  0
  0
  13
********  160
**************************  532
*******************************************  867
*************************************************  990
**************************************************  1000
**************************************************  1000
**************************************************  1000

 
 
 */