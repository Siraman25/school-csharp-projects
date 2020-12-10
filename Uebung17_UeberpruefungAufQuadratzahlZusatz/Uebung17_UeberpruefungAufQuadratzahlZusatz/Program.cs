using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung17_UeberpruefungAufQuadratzahlZusatz
{
    class Program
    {
        static void Main(string[] args)
        {
            string selector;
            do
            {
                Console.Clear();
                Console.Write("Geben Sie eine natürliche Zahl ein (keine Null): ");
                int Zahl = Convert.ToInt32(Console.ReadLine());
                if (Zahl < 1)
                {
                    Console.WriteLine("Falsche Angabe.");
                }
                else
                {
                    if (((Math.Sqrt(Zahl)) % 1) != 0)
                    {
                        Console.WriteLine("Keine Quadratzahl.");
                    }
                    else
                    {
                        Console.WriteLine("Quadratzahl.");
                    }
                }

                Console.Write("Möchten Sie das Programm widerholen? (Ja/Nein) ");
                selector = Console.ReadLine();
            } while (selector == "Ja");
        }
    }
}
