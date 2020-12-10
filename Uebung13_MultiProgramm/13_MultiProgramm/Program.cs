using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_MultiProgramm
{
    /*
     * TODOs:
     * - Program start
     * - Aufrunder
     * - Abrunder
     * - Fehlererkennung
     * - Widerholung
     */
    class Program
    {
        static void Main(string[] args)
        {
            int Selector;
            do
                ProgrammStart()
                Selector = Convert.ToInt32(Console.ReadLine());
                
            while ()

        }
        public static int Aufrunder (double NichtAufgerunden)
        { 
        }
        public static int Abrunder(double NichtAbgerundet)
        { 
        }
        public static void ProgrammStart()
        {
            Console.WriteLine("Wähle eine Funktion aus:");
            Console.WriteLine("1 - Aufrunder");
            Console.WriteLine("2 - Abrunder");
        }
    }
}
