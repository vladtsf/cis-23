using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TaxCalculator
{
    public class TaxCalculator
    {

        public class TaxInterval
        {
            public int Limit;
            public double Rate;

            public TaxInterval(int limit, double rate) {
                Limit = limit;
                Rate = rate;
            }           
        }

        private TaxInterval[] intervals;
        private int grossIncome = 0;

        public TaxCalculator()
            : this(
                new double[] { 30000, 50000, 100000, 200000, 250000 },
                new double[] { 0, .1, .2, .3, .35, .4 }
            ) { }

        public TaxCalculator(double[] intervals, double[] rates)
            : this(intervals.Select(s => DollarsToCents(s)).ToArray(), rates) { }

        public TaxCalculator(int[] intervals, double[] rates)
        {
            if (intervals.Length != rates.Length - 1)
            {
                throw new ArgumentException("You must specify rates for each interval");
            }

            Array.Sort(intervals);


            Length = rates.Length;
            this.intervals = new TaxInterval[Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                this[i] = new TaxInterval(intervals[i], rates[i]);
            }

            this[intervals.Length] = new TaxInterval(int.MaxValue, rates[intervals.Length]);

            // make sure they're unique
        }

        public TaxInterval this[int index]
        {
            get 
            {
                return intervals[index];
            }
            private set
            {
                intervals[index] = value;
            }
        }

        public int Length
        {
            get;
            private set;
        }

        public int GrossIncome
        {
            get
            {
                return grossIncome;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("An income value could not be negative.");
                }

                grossIncome = value;
            }
        }

        public int NetIncome
        {
            get
            {
                return GrossIncome - Tax;
            }
        }

        public int Tax
        {
            get
            {
                int tax = 0;
                int taxed = 0;
                int remainder = GrossIncome;

                for (int i = 0; i < Length && taxed < remainder; i++)
                {
                    int taxBase = Math.Min(remainder - taxed, this[i].Limit - taxed);
                    tax += (int) (((double) taxBase) * this[i].Rate);
                    taxed += taxBase;
                }

                return tax;
            }
        }

        public static double CentsToDollars(int cents)
        {
            return ((double)cents) / 100D;
        }

        public static int DollarsToCents(double dollars)
        {
            return (int)(dollars * 100D);
        }


        public override string ToString()
        {
            return String.Format("<TaxCalculator gross=${0} net=${1} tax=${2} />", CentsToDollars(GrossIncome), CentsToDollars(NetIncome), CentsToDollars(Tax));
        }
    }
}
