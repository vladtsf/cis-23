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

        public HourlyEmployee(string firstName, string lastName) : base(firstName, lastName) { }

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
            return (int) (HoursWorked.Total * Rate);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", Rate: ${0:0.00}/hr", TaxCalculator.TaxCalculator.CentsToDollars(Rate));
        }
    }
}
