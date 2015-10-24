using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.People
{
    abstract class Employee : Lab1.Person
    {
        public string Department;
        public abstract double GetAverageWeekHours();
        public abstract int GetTotalWage();

        public override string ToString()
        {
            return String.Format("Name: {0}, Department: {1}, Average Week Hours: {2}, Total Wage: ${3:0.00}", 
                FullName, 
                Department, 
                GetAverageWeekHours(), 
                TaxCalculator.TaxCalculator.CentsToDollars(GetTotalWage()));
        }

        public Employee(string firstName, string lastName) : base(firstName, lastName) { }
    }
}
