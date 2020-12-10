using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung09_NotenInWorten
{
    class Program
    {
        static void Main(string[] args)
        {
            int noteZahl;
            
            Console.Write("Gebe die Note in eine Zahl von 4-10 ein: ");
            noteZahl = Convert.ToInt32(Console.ReadLine());

            if (noteZahl == 4)
            {
                Console.WriteLine("Die Note ist eine Vier.");
            }
            else if (noteZahl == 5)
            {
                Console.WriteLine("Die Note ist eine Fünf.");
            }
            else if (noteZahl == 6)
            {
                Console.WriteLine("Die Note ist eine Sechs.");
            }
            else if (noteZahl == 7)
            {
                Console.WriteLine("Die Note ist eine Sieben.");
            }
            else if (noteZahl == 8)
            {
                Console.WriteLine("Die Note ist eine Acht.");
            }
            else if (noteZahl == 9)
            {
                Console.WriteLine("Die Note ist eine Neun.");
            }
            else if (noteZahl == 10)
            {
                Console.WriteLine("Die Note ist eine Zehn.");
            }
            else
            {
                Console.WriteLine("Eine Zahl von 4-10 wird benötigt.");
            }
            Console.ReadKey();
        }
    }
}
