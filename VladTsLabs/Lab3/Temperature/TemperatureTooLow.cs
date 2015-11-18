using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Temperature
{
    class TemperatureTooLow : TemperatureOutOfRange
    {
        public TemperatureTooLow() : base("The temperature's too low")
        {

        }
    }
}
