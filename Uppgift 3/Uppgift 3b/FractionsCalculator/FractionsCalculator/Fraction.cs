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
        
        public static Fraction Add(Fraction fOne, Fraction fTwo)
        {
            return new Fraction(fOne.getNumerator * fTwo.getDenominator + fTwo.getNumerator * fOne.getDenominator, fOne.getDenominator * fTwo.getDenominator);
        }

        public static Fraction Multiply (Fraction fOne, Fraction fTwo)
        {
            return new Fraction(fOne.getNumerator * fTwo.getNumerator, fOne.getDenominator * fTwo.getDenominator);
        }

        //isEqualTo

        //toString
    }
}
