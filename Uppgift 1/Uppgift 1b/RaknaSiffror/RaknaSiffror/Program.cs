using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int countZero = 0;
            int countEven = 0;
            int countOdd = 0;

            Console.WriteLine("Mata in ett heltal: ");
            input = Console.ReadLine();

            foreach (var x in input)
            {
                if (x.ToString() == "0")
                {
                    countZero++;
                }
                
                else if (x % 2 != 0) 
                {
                    countOdd++;
                }

                else if (x % 2 == 0)
                {
                    countEven++;
                }

                
            }

            Console.WriteLine("Antal nollor: {0}", countZero);
            Console.WriteLine("Antal udda: {0}", countOdd);
            Console.WriteLine("Antal jämna: {0}", countEven);

        }
    }
}
