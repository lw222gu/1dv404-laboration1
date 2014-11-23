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

        public Fraction(int numerator, int denominator)
        {
            getNumerator = numerator;
            getDenominator = denominator;

            if (denominator == 0)
            {
                throw new Exception("Nämnaren kan inte vara 0, mata in ett nytt nummer.");
            }
        }

        public static bool isNegative(Fraction fOne, Fraction fTwo)
        {
            if (fOne.getNumerator < 0 || fOne.getDenominator < 0)
            {
                return true;
            }

            else if (fTwo.getNumerator < 0 || fTwo.getDenominator < 0)
            {
                return true;
            }

            else 
            {
                return false;
            }
        }
        
        public static Fraction Add(Fraction fOne, Fraction fTwo)
        {
            Fraction fThree = new Fraction(fOne.getNumerator * fTwo.getDenominator + fTwo.getNumerator * fOne.getDenominator, fOne.getDenominator * fTwo.getDenominator);
            return fThree;
        }

        public static Fraction Multiply (Fraction fOne, Fraction fTwo)
        {
            Fraction fThree = new Fraction(fOne.getNumerator * fTwo.getNumerator, fOne.getDenominator * fTwo.getDenominator);
            return fThree;
        }

        public static bool isEqualTo (Fraction fOne, Fraction fTwo)
        {
            if (fOne.getNumerator / fOne.getDenominator == fTwo.getNumerator / fTwo.getDenominator)
            {
                return true;
            }

            else 
            {
                return false;
            }
        }

        public static string toString(Fraction fThree)
        {
            return string.Format("{0}/{1}", fThree.getNumerator, fThree.getDenominator);
        }
    }
}
