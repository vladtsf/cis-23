using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.People
{
    class ClassResult
    {
        public enum Grades {
            A = 4,
            B = 3,
            C = 2,
            D = 1,
            F = 0,
            W = -1
        }

        public string ClassName;
        int Grade;

        public ClassResult(string name, Grades grade)
        {
            ClassName = name;
            Grade = (int) grade;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", ClassName, (Grades) Grade);
        }
    }
}
