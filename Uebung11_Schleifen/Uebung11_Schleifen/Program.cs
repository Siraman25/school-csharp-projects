using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung11_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib die Zahl ein: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            {
                Console.WriteLine(i);

            } while (i++ < zahl)
            Console.ReadKey();
        }
    }
}
