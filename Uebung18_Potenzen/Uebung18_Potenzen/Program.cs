using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung18_Potenzen
{
    class Program
    {
        static void Main(string[] args)
        {
            string selector;
            do
            {
                Console.Write("Gib die Basis ein: ");
                double Basis = Convert.ToDouble(Console.ReadLine());
                Console.Write("Gib den Exponent ein: ");
                int Exponent = Convert.ToInt32(Console.ReadLine());
                double Ergebnis = Math.Pow(Basis, Exponent);
                Console.WriteLine("Das Ergebnis ist " + Ergebnis + ".");

                Console.Write("Möchten Sie das Programm wiederholen? (Ja/Nein) ");
                selector = Console.ReadLine();
            } while (selector == "Ja");
        }
    }
}
