﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung01_GaussscheOsterformel
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jahr, a, b, c, k, p, q, M, d, N, e, Ostern;
            Jahr = 0;
            a = 0;
            b = 0;
            c = 0;
            k = 0;
            p = 0;
            q = 0;
            M = 0;
            d = 0;
            N = 0;
            e = 0;
            Ostern = 0;


            Console.Write("Schreibe ein Jahr: ");
            Jahr = Convert.ToInt32(Console.ReadLine());
            a = Jahr % 19;                                                                                                      // Effektive Berechnung des Datums
            b = Jahr % 4;
            c = Jahr % 7;
            k = Jahr / 100;
            p = (8 * k + 13) / 25;
            q = k / 4;
            M = (15 + k - p - q) % 30;
            d = (19 * a + M) % 30;
            N = (4 + k - q) % 7;
            e = (2 * b + 4 * c + 6 * d + N) % 7;
            Ostern = (22 + d + e);
            if (d == 29 && e == 6)
                Ostern = 50;
            if (d == 28 && e == 6 && a > 10)
                Ostern = 49;

            if (Ostern > 31)
                Console.WriteLine(Ostern - 31 + " April " + Jahr + ", drücke eine Taste zum Beenden.");                                                              // Output
            else
                Console.WriteLine(Ostern + " März " + Jahr + ", drücke eine Taste zum Beenden.");


            Console.ReadKey();
        }

    }
}
