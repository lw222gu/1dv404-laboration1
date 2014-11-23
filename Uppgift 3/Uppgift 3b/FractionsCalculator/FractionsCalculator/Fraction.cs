using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsCalculator
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        public int getNumerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        public int getDenominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }

        public Fraction()
        {
            getNumerator = _numerator;
            getDenominator = _denominator;
        }

        public bool isNegative(int numerator, int denominator)
        {
            if (numerator < 0 || denominator < 0)
            {
                return true;
            }

            else 
            {
                return false;
            }
        }

    }
}
