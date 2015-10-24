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

        public FullTimeEmployee(string firstName, string lastName) : base(firstName, lastName) { }

        public override double GetAverageWeekHours() 
        {
            return 40;
        }

        public override int GetTotalWage() 
        {
            return Salary;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", Salary: ${0:0.00}", TaxCalculator.TaxCalculator.CentsToDollars(Salary));
        }
    }
}
