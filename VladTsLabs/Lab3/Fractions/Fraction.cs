using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Fractions
{
    struct Fraction
    {
        private static void getCommonDenominatorFraction(Fraction one, Fraction two, out Fraction _one, out Fraction _two)
        {
            long denominator = one.Denominator * two.Denominator;
            _one = new Fraction(one.Numerator * two.Denominator, denominator);
            _two = new Fraction(two.Numerator * one.Denominator, denominator);
        }

        private static void checkInitialization(Fraction one, Fraction two)
        {
            one.checkInitialization();
            two.checkInitialization();
        }

        private static long gcd(long left, long right)
        {
            while (right > 0)
            {
                long rem = left % right;
                left = right;
                right = rem;
            }

            return left;
        }

        private bool numSet, denSet;

        public bool Initialized
        {
            get
            {
                return numSet && denSet;
            }
        }
        private long num, den;

        public long Numerator
        {
            get
            {
                return num;
            }
            set
            {
                numSet = true;
                num = value;
            }
        }

        public long Denominator
        {
            get
            {
                return den;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0");
                }

                denSet = true;
                den = value;
            }
        }

        public Fraction(long numerator, long denominator = 1)
        {
            this.num = 0;
            this.den = 0;
            numSet = true;
            denSet = true;

            Numerator = numerator;
            Denominator = denominator;
        }

        private void checkInitialization()
        {
            if (!Initialized)
            {
                throw new FractionUninitializedException();
            }
        }

        public void Simplify()
        {
            checkInitialization();
            long gcd = Fraction.gcd(Numerator, Denominator);

            Numerator /= gcd;
            Denominator /= gcd;
        }

        public static Fraction operator *(Fraction one, Fraction two)
        {
            checkInitialization(one, two);
            return new Fraction(one.Numerator * two.Numerator, one.Denominator * two.Denominator);
        }

        public static Fraction operator /(Fraction one, Fraction two)
        {
            checkInitialization(one, two);
            return new Fraction(one.Numerator * two.Denominator, one.Denominator * two.Numerator);
        }

        public static Fraction operator +(Fraction one, Fraction two)
        {
            checkInitialization(one, two);
            Fraction left, right;
            getCommonDenominatorFraction(one, two, out left, out right);

            Fraction result = new Fraction(left.Numerator + right.Numerator, left.Denominator);
            result.Simplify();

            return result;
        }

        public static Fraction operator -(Fraction one)
        {
            return new Fraction(-one.Numerator, one.Denominator);
        }

        public static Fraction operator -(Fraction one, Fraction two)
        {
            checkInitialization(one, two);
            Fraction left, right;
            getCommonDenominatorFraction(one, two, out left, out right);

            Fraction result = new Fraction(left.Numerator - right.Numerator, left.Denominator);
            result.Simplify();

            return result;
        }

        public static bool operator <(Fraction one, Fraction two)
        {
            checkInitialization(one, two);
            Fraction left, right;
            getCommonDenominatorFraction(one, two, out left, out right);

            return left.Numerator < right.Numerator;
        }

        public static bool operator >(Fraction one, Fraction two)
        {
            checkInitialization(one, two);
            Fraction left, right;
            getCommonDenominatorFraction(one, two, out left, out right);

            return left.Numerator > right.Numerator;
        }

        public static bool operator ==(Fraction one, Fraction two)
        {
            checkInitialization(one, two);
            Fraction left, right;
            getCommonDenominatorFraction(one, two, out left, out right);

            return left.Numerator == right.Numerator;
        }

        public static bool operator !=(Fraction one, Fraction two)
        {
            checkInitialization(one, two);
            Fraction left, right;
            getCommonDenominatorFraction(one, two, out left, out right);

            return (one.Numerator != two.Numerator);
        }

        public static implicit operator double(Fraction f)
        {
            f.checkInitialization();
            return (double)f.Numerator / (double)f.Denominator; 
        }

        public static explicit operator int(Fraction f)
        {
            f.checkInitialization();
            return (int)(f.Numerator / f.Denominator);
        }
    }
}
