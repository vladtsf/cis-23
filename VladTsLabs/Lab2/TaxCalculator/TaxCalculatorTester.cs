using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TaxCalculator
{
    class TaxCalculatorTester
    {
        public static void RunTests()
        {
            TaxCalculator calc = new TaxCalculator();

            calc.GrossIncome = TaxCalculator.DollarsToCents(35000);

            Console.WriteLine(calc);
        }
    }
}
