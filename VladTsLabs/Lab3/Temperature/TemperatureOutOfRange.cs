using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Temperature
{
    class TemperatureOutOfRange : Exception
    {
        public TemperatureOutOfRange(String message) : base(message)
        {

        }
    }
}
