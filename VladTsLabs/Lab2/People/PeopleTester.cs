using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.People
{
    class PeopleTester
    {
        public static void RunTests()
        {
            Console.WriteLine("Testing People Classes.");

            Employee john = new FullTimeEmployee("John", "Doe") 
            {
                Department = "Criminal",
                Salary = TaxCalculator.TaxCalculator.DollarsToCents(5000)
            };

            Employee kane = new HourlyEmployee("Kane", "Cillian") 
            {
                Department = "Marketing",
                Rate = TaxCalculator.TaxCalculator.DollarsToCents(50),
                HoursWorked = new Workload(20, 30, 35, 40)
            };

            Student vladt = new Student("Vlad", "T")
            {
                TakenClasses = new List<ClassResult> {
                    new ClassResult("C#", ClassResult.Grades.F),
                    new ClassResult("JavaScript", ClassResult.Grades.C),
                    new ClassResult("Calculus", ClassResult.Grades.D)
                }
            };

            Console.WriteLine(john);
            Console.WriteLine(kane);
            Console.WriteLine(vladt);

            Console.WriteLine(Environment.NewLine + vladt.GenerateTranscript());
        }
    }
}


/*
Testing People Classes.
Name: John Doe, Department: Criminal, Average Week Hours: 40, Total Wage: $5000.00, Salary: $5000.00
Name: Kane Cillian, Department: Marketing, Average Week Hours: 125, Total Wage: $6250.00, Rate: $50.00/hr
<Person#1003 FirstName=Vlad, LastName=T>

Vlad T's Transcript
C#: F
JavaScript: C
Calculus: D
*/