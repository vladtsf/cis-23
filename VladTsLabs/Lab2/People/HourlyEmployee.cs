using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.People
{
    class HourlyEmployee : Employee
    {
        public int Rate;
        public Workload HoursWorked;

        public override double GetAverageWeekHours()
        {
            double total = 0;

            for (int i = 0; i < 4; i++)
            {
                total += HoursWorked[i];
            }

            return total;
        }

        public override int GetTotalWage()
        {
            return HoursWorked.Total * Rate;
        }
    }
}
