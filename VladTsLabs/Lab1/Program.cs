using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            new SphereTester().RunTests();
            Console.WriteLine();
            new PersonTester().RunTests();
            Console.WriteLine();
            new TagMakerTester().RunTests();
            Console.WriteLine();
            new AddressBookTester().RunTests();

            #if DEBUG
                Console.WriteLine();
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            #endif
        }
    }
}
