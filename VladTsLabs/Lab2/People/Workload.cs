using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.People
{
    struct Workload
    {
        double first, second, third, fourth;

        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return first;
                    case 1:
                        return second;
                    case 2:
                        return third;
                    case 3:
                        return fourth;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public double Total
        {
            get
            {
                return first + second + third + fourth;
            }
        }
    }
}
