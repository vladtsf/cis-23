using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Temperature
{
    class TemperatureTooHigh : TemperatureOutOfRange
    {
        public TemperatureTooHigh() : base("The temperature's too high")
        {

        }
    }
}
