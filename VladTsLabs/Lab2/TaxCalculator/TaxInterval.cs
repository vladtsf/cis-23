using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TaxCalculator
{

    class TaxInterval : IComparable
    {
        class InvalidTaxIntervalException : System.Exception {}
        private int from, to;
        private double rate;

        TaxInterval(int from, int to, double rate)
        {
            From = from;
            To = to;
            Rate = rate;
        }

        public static TaxInterval CreateFromDollars(double from, double to, double rate) 
        {
            if (Double.IsPositiveInfinity(from))
            {
                throw new InvalidTaxIntervalException();
            }

            int fromCents = (int)(from * 100);
            int toCents = Double.IsPositiveInfinity(to) ? int.MaxValue : (int)(to * 100);

            return new TaxInterval(fromCents, toCents, rate);
        }

        public int From
        {
            get {
                return from;
            }
            set {
                if (value < 0)
                {
                    throw new InvalidTaxIntervalException();
                }

                from = value;
            }
        }

        public int To
        {
            get
            {
                return to;
            }
            set
            {
                if (value < 0 || value <= From)
                {
                    throw new InvalidTaxIntervalException();
                }

                to = value;
            }
        }

        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new InvalidTaxIntervalException();
                }

                rate = value;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            TaxInterval other = obj as TaxInterval;

            if (other != null)
            {
                if (From >= other.To)
                {
                    return 1;
                }
                else if (To <= other.From)
                {
                    return -1;
                }

                return 0;
            }

            throw new ArgumentException("Object is not a TaxInterval");
        }

        private int GetTaxBase(int amount)
        {
            return Math.Max(Math.Min(amount - From, To - From), 0);
        }

        public int GetTax(int amount)
        {
            return (int) (GetTaxBase(amount) * Rate);
        }

        public int GetNetIncome(int amount)
        {
            return (int)(GetTaxBase(amount) * (1D - Rate));
        }
    }
}
