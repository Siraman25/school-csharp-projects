using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung05_Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Gib a ein: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gib b ein: ");
            b = Convert.ToDouble(Console.ReadLine());
            c = (a * a) + (b * b);
            c = Math.Sqrt(c);
            Console.WriteLine("Die Hypotenuse c beträgt " + c + ".");
            Console.ReadKey();
        }
    }
}
