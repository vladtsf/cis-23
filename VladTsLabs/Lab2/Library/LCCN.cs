using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Library
{
    struct LCCN
    {
        private int number;

        public LCCN(int number)
        {
            this.number = number;
        }

        public override string ToString()
        {
            string number = this.number.ToString().PadLeft(7, '0');
            return String.Format("{0}-{1}", number.Substring(0, 2), number.Substring(2, 5));
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value > 9999999 || value < 0) 
                {
                    throw new ArgumentOutOfRangeException();
                }

                number = value;
            }

        }
    }
}
