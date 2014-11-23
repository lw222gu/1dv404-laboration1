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
                    Fraction.Add(fOne, fTwo);
                    break;
                
                case "2":
                    Fraction.Multiply(fOne, fTwo);
                    break;
               
                case "3":
                    Fraction.isEqualTo(fOne, fTwo);
                    break;
            }



        }

        private static void ViewMenu()
        {
            Console.WriteLine("Ange vad du vill göra:");
            Console.WriteLine("1: Addera bråken.");
            Console.WriteLine("2: Multiplicera bråken.");
            Console.WriteLine("3: Kontrollera om bråken är likadana.");
        }
    }
}
