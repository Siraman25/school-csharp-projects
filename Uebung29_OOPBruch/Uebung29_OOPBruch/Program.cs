using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Uebung29_OOPBruch
{
    class Bruch
    {
        public int zaehler;
        public int nenner;

        public double Ergebnis(double ergZaehler, double ergNenner)
        {
            double erg = ergZaehler / ergNenner;
            return erg;

        }

        public int[] Erweitern(int ergZaehler, int ergNenner, int multiplikator)
        {
            int[] erg = new int[2];
            erg[0] = ergZaehler * multiplikator;
            erg[1] = ergNenner * multiplikator;
            return erg;
        }

        public int[] Kuerzen(int ergZaehler, int ergNenner, int teiler)
        {
            int[] erg = new int[2];
            double ergebnisZaehler = ergZaehler % teiler;
            double ergebnisNenner = ergNenner % teiler;

            if (ergebnisNenner == 0 && ergebnisZaehler == 0)
            {
                erg[0] = ergZaehler / teiler;
                erg[1] = ergNenner / teiler;
            }
            else
            {
                erg[0] = -88;
                erg[1] = -88;
            }

            return erg;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bruch BruchRechnung = new Bruch();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Wählen Sie eine Funktion aus:");
                Console.WriteLine("1 - Zähler und Nenner auswählen");
                Console.WriteLine("2 - Bruch anzeigen und ausrechnen");
                Console.WriteLine("3 - Erweitern mit Multiplikator");
                Console.WriteLine("4 - Kürzen");
                Console.WriteLine("5 - Programm beenden");
                int selector = Convert.ToInt32(Console.ReadLine());
                switch (selector)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Nenner:");
                        BruchRechnung.nenner = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Zaehler:");
                        BruchRechnung.zaehler = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(BruchRechnung.zaehler);
                        Console.WriteLine("--");
                        Console.WriteLine(BruchRechnung.nenner);
                        Console.WriteLine("Berechnung:");
                        Console.WriteLine(BruchRechnung.Ergebnis(BruchRechnung.zaehler, BruchRechnung.nenner));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Wählen Sie den Multiplikator:");
                        int multi = Convert.ToInt32(Console.ReadLine());
                        int[] erg = new int[2];
                        erg = BruchRechnung.Erweitern(BruchRechnung.zaehler, BruchRechnung.nenner, multi);
                        Console.WriteLine(erg[0]);
                        Console.WriteLine("--");
                        Console.WriteLine(erg[1]);
                        Console.WriteLine("Berechnung:");
                        Console.WriteLine(BruchRechnung.Ergebnis(erg[0], erg[1]));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Wählen Sie den Teiler:");
                        int teiler = Convert.ToInt32(Console.ReadLine());
                        int[] ergebnis = new int[2];
                        ergebnis = BruchRechnung.Kuerzen(BruchRechnung.zaehler, BruchRechnung.nenner, teiler);
                        if (ergebnis[0] == -88 && ergebnis[1] == -88)
                        {
                            Console.WriteLine("Fehler beim Rechnen. Bitte wählen Sie einen anderen Teiler.");
                        }
                        else
                        {
                            Console.WriteLine(ergebnis[0]);
                            Console.WriteLine("--");
                            Console.WriteLine(ergebnis[1]);
                            Console.WriteLine("Berechnung:");
                            Console.WriteLine(BruchRechnung.Ergebnis(ergebnis[0], ergebnis[1]));
                            Console.ReadKey();
                        }

                        Console.ReadKey();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}