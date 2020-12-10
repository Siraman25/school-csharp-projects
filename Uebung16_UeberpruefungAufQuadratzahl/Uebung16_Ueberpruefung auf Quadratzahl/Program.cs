using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string selector;
            do
            {
                Console.Clear();
                Console.Write("Geben Sie eine natürliche Zahl (keine Null) ein: ");
                int ZahlEingabe = Convert.ToInt32(Console.ReadLine());
                if (ZahlEingabe < 1)
                {
                    Console.WriteLine("Falsche Zahl angegeben!");
                }
                else
                {
                    Console.WriteLine(Berechnung(0, 1, ZahlEingabe));
                }
                Console.Write("Möchten Sie wiederholen? (Ja/Nein) ");
                selector = Console.ReadLine();
            } while (selector == "Ja");

        }

        /*
         * Rekursive Funktion, die Angibt ob die angegebene Zahl eine Quadratzahl ist oder nicht.
         * Aris Mandolini
         * 08.11.2020
         */
        public static string Berechnung(int prenumber, int secondnumber, int sumnumber)
        {
            if (prenumber > sumnumber)
            {
                return "Keine Quadratzahl.";
            }
            else if (prenumber < sumnumber)
            {
                prenumber = prenumber + secondnumber;
                secondnumber = secondnumber + 2;
                string output = Berechnung(prenumber, secondnumber, sumnumber);
                return output;
            }
            else
            {
                return "Quadratzahl.";
            }
        }
    }
}
