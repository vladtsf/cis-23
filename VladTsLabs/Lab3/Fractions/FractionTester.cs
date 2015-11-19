using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Fractions
{
    class FractionTester
    {
        public static void RunTests()
        {
            Console.WriteLine(Environment.NewLine + "Testing Fractions");

            Console.WriteLine("1/2={0}", (int)new Fraction(1, 2));
            Console.WriteLine("1/2={0}", (double)new Fraction(1, 2));
            Console.WriteLine("1/2 + 1/4={0}", (double)(new Fraction(1, 2) + new Fraction(1,4)));
            Console.WriteLine("1/2 - 1/4={0}", (double)(new Fraction(1, 2) - new Fraction(1,4)));
            Console.WriteLine("1/2 * 1/4={0}", (double)(new Fraction(1, 2) * new Fraction(1,4)));
            Console.WriteLine("1/2 == 2/4: {0}", new Fraction(1, 2) == new Fraction(2,4));
            Console.WriteLine("1/2 != 1/4: {0}", new Fraction(1, 2) != new Fraction(1,4));
            Console.WriteLine("-(1/2)={0}", (double)(-new Fraction(1, 2)));

            Fraction fr = new Fraction(1, 2);

            Console.WriteLine("fr = 1/2; fr += 1/4 // {0}", (double)(fr += new Fraction(1, 4)));
        }
    }
}

/*
Testing Fractions
1/2=0
1/2=0.5
1/2 + 1/4=0.75
1/2 - 1/4=0.25
1/2 * 1/4=0.125
1/2 == 2/4: True
1/2 != 1/4: False
-(1/2)=-0.5
fr = 1/2; fr += 1/4 // 0.75
*/