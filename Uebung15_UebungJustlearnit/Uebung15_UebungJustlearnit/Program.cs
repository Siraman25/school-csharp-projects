using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung15_UebungJustlearnit
{
    class MainClass
    {
        /*
         * Funktion mittelwert
         * Berechnet den Mittelwert zweier Parameter 
         */
        public static double mittelwert(double note1, double note2)
        {
            double mean;
            mean = (note1 + note2) / 2;
            return mean;
        }
        /*
         * Funktion berechneSumme1bisn
         * Berechnet den die Summe aller natürlichen Zahlen zwischen 1 und der angegebenen Grenze
         */
        public static int berechneSumme1bisn(int zahl)
        {
            if (zahl >= 0)
            {
                int ergebnis = zahl * (zahl + 1) / 2;
                return ergebnis;
            }
            else
            {
                return 0;
            }
        }
        /*
         * Check if n is prime
         * returns boolean true if prime, false otherwise
         */
        public static bool isPrime1(int n)
        {
            int nullcounter = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    nullcounter++;
                }
            }
            if (nullcounter == 2)
                return (true);
            else
                return (false);
        }
        /*
        * Check if n is prime
        * returns boolean true if prime, false otherwise
        */
        public static bool isPrime2(int n)
        {
            int nullcounter = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    nullcounter++;
                }
            }
            if (nullcounter == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        /*
        * Check if n is prime
        * returns boolean true if prime, false otherwise
        */
        public static bool isPrime3(int n)
        {
            int nullcounter = 0;
            for (int i = 2; i < n; i++)
                if (n % i == 0) nullcounter++;
            return (nullcounter == 0);
        }
        /*
        * Check if n is prime
        * returns boolean true if prime, false otherwise
        */
        public static bool isPrime4(int n)
        {
            int nullcounter = 0;
            int i = 2;
            while (i < n && nullcounter == 0)
            {
                if (n % i == 0)
                {
                    nullcounter++;
                }
                i++;
            }
            return (nullcounter == 0);
        }
        /*
        * Check if n is prime
        * returns boolean true if prime, false otherwise
        */
        public static bool isPrime5(int n)
        {
            int nullcounter = 0;
            int i = 2;
            while (i <= Math.Sqrt(n) && nullcounter == 0)
            {
                if (n % i == 0)
                {
                    nullcounter++;
                }
                i++;
            }
            return (nullcounter == 0);
        }


        public static void Selection()
        {
            Console.WriteLine("Wähle ein Programm aus:");
            Console.WriteLine("1 - Gibt an ob Zahl prim ist oder nicht.");
            Console.WriteLine("2 - Gibt den Mittelwert zwei Zahlen an.");
            Console.WriteLine("3 - Berechnet den die Summe aller natürlichen Zahlen zwischen 1 und der angegebenen Grenze.");
            Console.WriteLine("4 - Alle Primzahlen von 1 bis 1000000.");
            Console.WriteLine("5 - Beendet das Programm.");
        }

        public static void Main(string[] args)
        {
            do
            {
                int selector = 0;
                do
                {
                    Console.Clear();
                    Selection();
                    selector = Convert.ToInt32(Console.ReadLine());

                } while (selector > 5 || selector < 1);

                int Zahl;
                double Zahl1, Zahl2;
                bool prime = false;
                switch (selector)
                {
                    case 1:
                        Console.Write("Gib eine Zahl an: ");
                        Zahl = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(isPrime5(Zahl));
                        break;
                    case 2:
                        Console.Write("Gib die erste Zahl an: ");
                        Zahl1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Gib die zweite Zahl an: ");
                        Zahl2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(mittelwert(Zahl1, Zahl2));
                        break;
                    case 3:
                        Console.Write("Gib eine Zahl an: ");
                        Zahl = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(berechneSumme1bisn(Zahl));
                        break;
                    case 4:
                        for (int i = 1; i <= 1000000; i++)
                        {
                            prime = isPrime5(i);
                            if (prime == true)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine("Eine beliebige Taste drücken zum fortfahren...");
                        break;
                    case 5:
                        System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            } while (0 == 0);
        }
    }
}

/*
 * Die 5 ist schneller als die 1 da sie die Bedingung in der Schleife verschachtelt hat, deshalb hat sie eine Bedingung weniger.
 */
