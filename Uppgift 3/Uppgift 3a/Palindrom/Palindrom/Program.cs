using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabler
            string input;
            string copyOfInput;
            bool equal;

            //Läs in en textsträng och skapa en kopia
            Console.WriteLine("Ange ett ord eller en mening som du vill kontrollera om det är ett palindrom: ");
            input = Console.ReadLine();

            //Gör textsträngen till enbart gemener och skapa en kopia
            input = input.ToLower();
            copyOfInput = String.Copy(input);

            //Vänd på strängen med hjälp av en char array.
            char[] stringArray = copyOfInput.ToCharArray();
            Array.Reverse(stringArray);
            copyOfInput = new string(stringArray);

            //Jämför strängarna och skriv ut resultatet
            //"Sirap i Paris" är ett palindrom.
            //"Hejsan" är inte ett palindrom.

            equal = input.Equals(copyOfInput, StringComparison.Ordinal);
            
            if (equal == true)
            {
                Console.WriteLine("Den inmatade texten '{0}' är ett palindrom.", input);
            }

            else if (equal == false)
            {
                Console.WriteLine("Den inmatade texten '{0}' är inte ett palindrom.", input);
            }
            
        }
    }
}
