using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TaxCalculator
{
    class TaxCalculator
    {
        private TaxInterval[] intervals;
        private int grossIncome = 0;

        //public TaxCalculator()
        //    : this(
        //        TaxInterval.CreateFromDollars(0, 30000, 0F),
        //        TaxInterval.CreateFromDollars(30000.01, 50000, .1),
        //        TaxInterval.CreateFromDollars(50000.01, 100000, .2),
        //        TaxInterval.CreateFromDollars(100000.01, 200000, .3),
        //        TaxInterval.CreateFromDollars(200000.01, 250000, .35),
        //        TaxInterval.CreateFromDollars(250000.01, Double.PositiveInfinity, .4)
        //    ) { }

        //public TaxCalculator(params TaxInterval[] taxIntervals)
        //{
        //    Intervals = taxIntervals;
        //}

        public TaxCalculator(params int[] taxIntervals)
        {
            TaxInterval[] intervals = new TaxInterval[taxIntervals.Length];

            Array.Sort(taxIntervals);

            for (int i = 1; i < taxIntervals.Length; i++)
            {
                if (taxIntervals[i] == taxIntervals[i - 1]) {
                    throw new ArgumentException("The passed intervals must not overlap.");
                }
            }

            for (int i = 0; i < taxIntervals.Length; i++)
            {
                //intervals[i] = new TaxInterval((i == 0 ? 0 : taxIntervals[i - 1]), taxIntervals[i])
            }
        }

        public TaxInterval[] Intervals
        {
            get
            {
                return intervals;
            }
            private set
            {
                Array.Sort(value);

                for (int i = 1; i < value.Length; i++)
                {
                    if (value[i] == value[i - 1])
                    {
                        throw new ArgumentException("The passed intervals must not overlap.");
                    }
                }

                intervals = value;
            }
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
                int total = 0;

                foreach (TaxInterval interval in Intervals)
                {
                    total += interval.GetNetIncome(GrossIncome);
                }

                return total;
            }
        }

        public int Tax
        {
            get
            {
                int total = 0;

                foreach (TaxInterval interval in Intervals)
                {
                    total += interval.GetTax(GrossIncome);
                }

                return total;
            }
        }

        public static double CentsToDollars(int cents)
        {
            return ((double) cents) / 100D;
        }

        public static int DollarsToCents(double dollars)
        {
            return (int) (dollars * 100D);
        }

        public override string ToString()
        {
            return String.Format("<TaxCalculator gross={0} net={1} tax={2} />", CentsToDollars(GrossIncome), CentsToDollars(NetIncome), CentsToDollars(Tax));
        }
    }
}
