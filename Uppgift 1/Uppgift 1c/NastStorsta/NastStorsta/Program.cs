using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {

            int largestNumber = 0;
            int secondLargestNumber = 0;
            int input;
            int numbers;

            Console.Write("Ange hur många tal du vill mata in: ");
            numbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbers; i++)
            {
                Console.Write("Ange tal {0}: ", i);
                input = int.Parse(Console.ReadLine());

                if(i == 1)
                {
                    largestNumber = input;
                }

                if (i == 2)
                {
                    if (input > largestNumber)
                    {
                        secondLargestNumber = largestNumber;
                        largestNumber = input;
                    }

                    else
                    {
                        secondLargestNumber = input;
                    }
                }

                else
                {
                    if (input < largestNumber && input > secondLargestNumber)
                    {
                        secondLargestNumber = input;
                    }

                    else if (input > largestNumber)
                    {
                        secondLargestNumber = largestNumber;
                        largestNumber = input;
                    }
                }

                
            }

            Console.WriteLine("Det näst största talet är {0}.", secondLargestNumber);
        }
    }
}
