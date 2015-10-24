using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.People
{
    class Student : Lab1.Person
    {
        public List<ClassResult> TakenClasses;

        public Student(string firstName, string lastName) : base(firstName, lastName) { }

        public string GenerateTranscript()
        {
            string result = String.Format("{0}'s Transcript", FullName);

            foreach (ClassResult c in TakenClasses)
            {
                result += Environment.NewLine + c;
            }

            return result;
        }
    }
}
