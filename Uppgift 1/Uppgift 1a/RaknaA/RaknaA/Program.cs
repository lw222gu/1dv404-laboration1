using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            int aLowerCase = 0;
            int aUpperCase = 0;

            Console.Write("Mata in en valfri textrad i vilken du vill beräkna antalet a och A: ");
            inputString = Console.ReadLine();

            foreach (char x in inputString) 
            {
                if(x == 'a')
                {
                    aLowerCase++;
                }

                if (x == 'A')
                {
                    aUpperCase++;
                }
            }

            Console.WriteLine("Antal a: {0}", aLowerCase);
            Console.WriteLine("Antal A: {0}", aUpperCase);
        }
    }
}
