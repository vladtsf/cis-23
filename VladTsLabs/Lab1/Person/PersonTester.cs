using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class PersonTester
    {
        private Person Me, Professor;

        public PersonTester() 
        {
            Me = new Person("Vlad", "Tsvang");
            Professor = new Person("Paramsothy", "Thananjeyan");
        }

        public void RunTests()
        {
            Console.WriteLine("Testing Person");

            Console.WriteLine(Me);
            Console.WriteLine(Professor);

            Console.WriteLine("Setters work...");
            Me.FirstName = "Mr. " + Me.GetFirstName();
            Me.LastName = "T";
            Console.WriteLine(Me);

            Console.WriteLine("My name is " + Me.FullName + ". Yes, " + Me.GetFullName());
            Console.WriteLine("My number is " + Me.ID + " and you never can change it.");
            Console.WriteLine("My C# professor is {0}", Professor.FullName);

            Console.WriteLine("Done testing the Person class!");
        }
    }
}
