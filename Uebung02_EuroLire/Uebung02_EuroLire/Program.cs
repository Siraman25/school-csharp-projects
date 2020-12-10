using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung02_EuroLire
{
    class Program
    {
        static void Main(string[] args)
        {
            int euro, lire;

            Console.Write("Euro: ");
            euro = Convert.ToInt32(Console.ReadLine());
            lire = euro * 1936;

            Console.WriteLine("Lire: " + lire + ", drücken Sie eine Taste zum Beenden.");

            Console.ReadKey();

        }
    }
}
