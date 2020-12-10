using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung06_Minderjaehrig
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Wie alt bist du? ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Du bist Minderjährig.");
            }
            else
            {
                Console.WriteLine("Du bist Volljährig.");
            }
            Console.ReadKey();
        }
    }
}
