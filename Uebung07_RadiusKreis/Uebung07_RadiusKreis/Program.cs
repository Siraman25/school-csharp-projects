using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung07_RadiusKreis
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, output;
            string FoderU;
            Console.Write("Gebe den Radius an: ");
            radius = Convert.ToDouble(Console.ReadLine());

            if ((double)radius <= 0)
            {
                Console.WriteLine("Der Radius ist entwer 0 oder Negativ.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Möchtest du (U)mfang oder (F)läche berechnen? ");
                FoderU = Console.ReadLine();

                if (FoderU == "F")
                {
                    output = Math.PI * radius * radius;
                    Console.WriteLine("Die Fläche beträgt " + output + ".");
                }
                else if (FoderU == "U")
                {
                    output = 2 * Math.PI * radius;
                    Console.WriteLine("Der Umfang beträgt " + output + ".");
                }
                else
                {
                    Console.WriteLine("Du hast eine falsche Angabe gegeben.");
                }

        Console.ReadKey();
            }
        }
    }
}
