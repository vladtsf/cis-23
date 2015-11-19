using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Fractions
{
    class FractionUninitializedException : Exception
    {
        public FractionUninitializedException() : base("I can't perform any arithmetic operations on an uninitialized fraction.")
        {

        }
    }
}
