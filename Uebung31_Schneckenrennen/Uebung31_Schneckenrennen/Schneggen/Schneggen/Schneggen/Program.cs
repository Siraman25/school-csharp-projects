using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schneggen
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** Erstelle ein paar Schnecken
            Schnecke erste = new Schnecke("Maria", "Schwarzhaube", 4.0);
            Schnecke zweite = new Schnecke("Sara", "Schwarzhaube", 4.1);
            Schnecke dritte = new Schnecke("Giovanna", "Graubin", 4.1);
            Schnecke vierte = new Schnecke("Hallodrio", "Graubin", 4.2);
            #region test
            //for (int i = 0; i < 5; i++)
            //{
            //    erste.kriechen();
            //    zweite.kriechen();
            //    dritte.kriechen();
            //    vierte.kriechen();
            //}
            //Console.WriteLine(erste.toString());
            //Console.WriteLine(zweite.toString());
            //Console.WriteLine(dritte.toString());
            //Console.WriteLine(vierte.toString());
#endregion
            //*** Erstelle ein Rennen und füge einige Schnecken hinzu
            SchneckenRennen myRace = new SchneckenRennen("My Schneggele Race", 5, 10);
            myRace.addSchnecke(erste);
            myRace.addSchnecke(zweite);
            myRace.addSchnecke(dritte);

            //*** Rennen durchführen und Ergebnis ausgeben
            myRace.durchfuehren();
            Console.WriteLine(myRace.toString());
            Console.WriteLine("SIEGER: " + myRace.ermittleGewinner().toString());

            Console.ReadKey();
        }
    }
}
