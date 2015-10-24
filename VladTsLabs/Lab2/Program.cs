using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator.TaxCalculatorTester.RunTests();
            Histogram.RandomNumberTester.RunTests();
            Deck.DeckTester.RunTests();
            Library.LibraryTester.RunTests();
            People.PeopleTester.RunTests();

            #if DEBUG
                Console.WriteLine();
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            #endif
        }
    }
}
