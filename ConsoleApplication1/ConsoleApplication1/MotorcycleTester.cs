using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Motorcycle;

namespace MotorcycleTester
{
    class MotorcycleTester
    {
        public static void Main(string[] args)
        {
            MotorCycle m = new MotorCycle();
            m.Make = "Yamaha RZ350";
            m.Color = "yellow";
            System.Console.WriteLine("Calling ShowAtts...");
            m.ShowAtts();
            System.Console.WriteLine("________");
            System.Console.WriteLine("Starting engine...");
            m.StartEngine();
            System.Console.WriteLine("________");
            System.Console.WriteLine("Calling ShowAtts...");
            m.ShowAtts();
            System.Console.WriteLine("________");
            System.Console.WriteLine("Starting engine...");
            m.StartEngine();
        }
    }
}
