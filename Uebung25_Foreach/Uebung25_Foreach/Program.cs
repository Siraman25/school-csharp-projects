using System;
using System.Collections;

namespace Uebung25_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] zahlen = {1.1, 2.3, 4.5};

            foreach (double Zahl in zahlen)
            {
                Console.WriteLine(Zahl);
            }

            ArrayList meineListe = new ArrayList();

            meineListe.Add(2);
            meineListe.Add(5);
            meineListe.Add(7);
            meineListe.Add(9);

            foreach (int Zahl2 in meineListe)
            {
                Console.WriteLine(Zahl2);
            }
        }
    }
}