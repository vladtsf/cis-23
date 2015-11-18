using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Temperature
{
    class ThermostatTester
    {
        public static void RunTests()
        {
            Thermostat t = new Thermostat(0, 100);

            Console.WriteLine(Environment.NewLine + "Testing Thermostat");

            t.SetTemp(50);

            try
            {
                t.SetTemp(150);
            }
            catch(TemperatureTooLow e)
            {
                Console.WriteLine(e.Message);
            }
            catch(TemperatureOutOfRange e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                try
                {
                    t.SetTemp(-50);
                }
                catch (TemperatureTooLow e)
                {
                    throw new Exception("I don't know how to handle it...", e);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("I know how to handle rethrown exceptions!");
            }
        }
    }
}

/*
Testing Thermostat
The temperature's too high
I know how to handle rethrown exceptions!
*/