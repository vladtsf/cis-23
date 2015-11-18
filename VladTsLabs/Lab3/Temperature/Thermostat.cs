using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Temperature
{
    class Thermostat
    {
        private int min, max;
        public int Temperature { get; private set; }

        public Thermostat(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public void SetTemp(int temp)
        {
            if(temp < min)
            {
                throw new TemperatureTooLow();
            } else if(temp > max)
            {
                throw new TemperatureTooHigh();
            }

            Temperature = temp;
        }
    }
}
