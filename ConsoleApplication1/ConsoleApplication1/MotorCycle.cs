using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    class MotorCycle
    {
        public string Make;
        public string Color;
        public bool EngineState;

        public void StartEngine() 
        {
            if (EngineState == true)
            {
                System.Console.WriteLine("The engine is already on.");
            }
            else
            {
                EngineState = true;
                System.Console.WriteLine("The engine is now on");
            }
        }

        public void ShowAtts()
        {
            System.Console.WriteLine("This motorcycle is a "
                + Color + " " + Make);

            if (EngineState == true)
            {
                System.Console.WriteLine("The engine is on");
            }
            else
            {
                System.Console.WriteLine("The engine is off");
            }
        }
    }
}
