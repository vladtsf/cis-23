using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.People
{
    class FullTimeEmployee : Employee
    {
        public int Salary;

        public override double GetAverageWeekHours() 
        {
            return 40;
        }

        public override int GetTotalWage() 
        {
            return Salary;
        }
    }
}
