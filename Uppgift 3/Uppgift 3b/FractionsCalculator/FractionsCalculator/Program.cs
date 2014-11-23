using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator1;
            int denominator1;
            int numerator2;
            int denominator2;

            Console.Write("Ange nämnaren i det första bråket: ");
            numerator1 = int.Parse(Console.ReadLine());

            Console.Write("Ange täljaren i det första bråket: ");
            denominator1 = int.Parse(Console.ReadLine());

            Console.Write("Ange nämnaren i det andra bråket: ");
            numerator2 = int.Parse(Console.ReadLine());

            Console.Write("Ange täljaren i det andra bråket: ");
            denominator2 = int.Parse(Console.ReadLine());

            Fraction fOne = new Fraction(numerator1, denominator1);
            Fraction fTwo = new Fraction(numerator2, denominator2);

            ViewMenu();

            switch (Console.ReadLine())
            { 
                case "1":
                    ViewResult(Fraction.Add(fOne, fTwo));
                    break;
                
                case "2":
                    ViewResult(Fraction.Multiply(fOne, fTwo));
                    break;
               
                case "3":
                    ViewResultEqual(fOne, fTwo);
                    break;

                case "4":
                    ViewResultNegative(fOne, fTwo);
                    break;
            }

        }

        public static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("Ange vad du vill göra:");
            Console.ResetColor();
            Console.WriteLine("1: Addera bråken.");
            Console.WriteLine("2: Multiplicera bråken.");
            Console.WriteLine("3: Kontrollera om bråken är likadana.");
            Console.WriteLine("4: Kontrollera om något av bråken är negativt.");
            Console.WriteLine("Ange ditt val [1-4]: ");
        }

        public static void ViewResult(Fraction fThree)
        {
            string result = Fraction.toString(fThree);
            Console.WriteLine("Resultatet är: {0}", result);
        }

        public static void ViewResultEqual(Fraction fOne, Fraction fTwo)
        {
            bool equal = Fraction.isEqualTo(fOne, fTwo);

            if (equal == true)
            {
                Console.WriteLine("De inmatade bråken är lika.");
            }

            else
            {
                Console.WriteLine("De inmatade bråken är olika.");
            }
        }

        public static void ViewResultNegative(Fraction fOne, Fraction fTwo)
        {
            bool negative = Fraction.isNegative(fOne, fTwo);

            if (negative == true)
            {
                Console.WriteLine("Minst ett av dina bråk är negativt.");
            }

            else 
            {
                Console.WriteLine("Inget av dina bråk är negativt.");
            }
 
        }
    }
}
