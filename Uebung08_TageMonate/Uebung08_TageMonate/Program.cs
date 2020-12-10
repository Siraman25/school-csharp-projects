using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung08_TageMonate
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            Console.Write("Schreibe den Monat: ");
            month = Console.ReadLine();

            if (month == "Jänner")
            {
                Console.WriteLine("31 Tage");
            }
            else if (month == "Januar")
            {
                Console.WriteLine("31 Tage");
            }
            else if (month == "Februar")
            {
                Console.WriteLine("28(29) Tage");
            }
            else if (month == "März")
            {
                Console.WriteLine("31 Tage");
            }
            else if (month == "April")
            {
                Console.WriteLine("30 Tage");
            }
            else if (month == "Mai")
            {
                Console.WriteLine("31 Tage");
            }
            else if (month == "Juni")
            {
                Console.WriteLine("30 Tage");
            }
            else if (month == "Juli")
            {
                Console.WriteLine("31 Tage");
            }
            else if (month == "August")
            {
                Console.WriteLine("31 Tage");
            }
            else if (month == "September")
            {
                Console.WriteLine("30 Tage");
            }
            else if (month == "Oktober")
            {
                Console.WriteLine("31 Tage");
            }
            else if (month == "November")
            {
                Console.WriteLine("30 Tage");
            }
            else if (month == "Dezember")
            {
                Console.WriteLine("31 Tage");
            }
            else
            {
                Console.WriteLine("Du hast kein Monat angegeben. Programm wird beendet.");
            }
        Console.ReadKey();
        }
    }
}
