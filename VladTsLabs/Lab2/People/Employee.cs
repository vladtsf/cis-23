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
    }
}
