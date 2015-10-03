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
            Console.WriteLine("Default Tax Rates");
            TaxCalculator calc = new TaxCalculator();

            calc.GrossIncome = TaxCalculator.DollarsToCents(35000);
            Console.WriteLine(calc);

            calc.GrossIncome = TaxCalculator.DollarsToCents(55000);
            Console.WriteLine(calc);

            calc.GrossIncome = TaxCalculator.DollarsToCents(125000);
            Console.WriteLine(calc);

            calc.GrossIncome = TaxCalculator.DollarsToCents(300000);
            Console.WriteLine(calc);

            Console.WriteLine();
            Console.WriteLine("Increase one of the Rates");
            calc[1].Rate = .2;
            calc[1].Limit = TaxCalculator.DollarsToCents(40000);
            Console.WriteLine(calc);

            Console.WriteLine();
            Console.WriteLine("Define Custom Rates");
            TaxCalculator calc2 = new TaxCalculator(
                new double[] { 30000, 40000, 50000, 60000, 250000 },
                new double[] { 0, .1, .2, .3, .35, .5 }    
            );
            calc2.GrossIncome = TaxCalculator.DollarsToCents(300000);
            Console.WriteLine(calc2);
        }
    }
}

/*
Default Tax Rates
<TaxCalculator gross=$35000 net=$34500 tax=$500 />
<TaxCalculator gross=$55000 net=$52000 tax=$3000 />
<TaxCalculator gross=$125000 net=$105500 tax=$19500 />
<TaxCalculator gross=$300000 net=$220500 tax=$79500 />

Increase one of the Rates
<TaxCalculator gross=$300000 net=$218500 tax=$81500 />

Define Custom Rates
<TaxCalculator gross=$300000 net=$202500 tax=$97500 />

Press enter to close...
*/