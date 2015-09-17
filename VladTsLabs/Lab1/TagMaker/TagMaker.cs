using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TagMaker
    {
        private string name, organization;
        private const int WIDTH = 78;
        private const int MARGIN = 3;

        class ValueIsTooLongException : System.Exception
        {
            public ValueIsTooLongException(String value) : base(FormatMessage(value)) { }

            private static string FormatMessage(string value) {
                return String.Format("The value \"{0}\" won't fit the line", value);
            }
        }

        public TagMaker(string name, string organization)
        {
            Name = name;
            Organization = organization; 
        }

        public string Name
        {
            get { return name; }
            set {
                if (GetPaddings(String.Format("NAME: {0}", value))[1] < 0)
                {
                    throw new ValueIsTooLongException(value);
                }
                name = value; 
            }
        }

        public string Organization
        {
            get { return organization; }
            set {
                if (GetPaddings(String.Format("ORGANIZATION: {0}", value))[1] < 0)
                {
                    throw new ValueIsTooLongException(value);
                } 
                organization = value;
            }
        }

        public void ClearName()
        {
            Name = "";
        }

        public void ClearOrganization()
        {
            Organization = "";
        }

        public void Print()
        {
            Print(Name, Organization);
        }

        public void PrintBlank()
        {
            Print("", "");
        }

        private void Print(string name, string organization)
        {
            string output = "";

            string hr = new String('#', WIDTH) + "\n";
            

            output += hr;
            output += FormatLine("ANNUAL CONFERENCE");
            output += hr;
            output += FormatLine(String.Format("NAME: {0}", name), true);
            output += FormatLine(" ");
            output += hr;
            output += FormatLine(String.Format("ORGANIZATION: {0}", organization), true);
            output += FormatLine(" ");
            output += hr;

            Console.WriteLine(output);
        }

        // Helper methods
        private static string FormatLine(string str, bool pullLeft = false) 
        {
            string output = "";
            string margin = new String('#', MARGIN);
            int[] paddings = GetPaddings(str, pullLeft);

            output += margin;
            output += new String(' ', paddings[0]);
            output += str;
            output += new String(' ', paddings[1]);
            output += margin;
            output += "\n";

            return output;
        }

        private static int[] GetPaddings(string str, bool pullLeft = false)
        {
            int[] paddings = { 0, 0 };

            int remaining = WIDTH;

            //subtracting the size of the margins
            remaining -= MARGIN * 2;

            //subtracting the string length
            remaining -= str.Length;

            if (pullLeft)
            {
                paddings[0] = 1;
                paddings[1] = remaining - 1;
            }
            else
            {
                int half = remaining / 2;

                paddings[0] = half;
                paddings[1] = half * 2 < remaining ? half + 1 : half;
            }

            return paddings;
        }
    }
}
