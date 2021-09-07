using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schneggen
{
    class SchneckenRennen
    {
        public string name;         // Bezeichnung des Rennens
        public int anzahl;          // Anzahl der Teilnehmer
        public int maxAnzahl;       // Kapazität des Rennens
        public double rennStrecke;  // Länge der Rennstrecke in cm
        Schnecke[] listeSchnecken;
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="n">Bezeichnung</param>
        /// <param name="max">Maximale Anzahl der Teilnehmer</param>
        /// <param name="rs">Länge der Rennstrecke in cm</param>
        public SchneckenRennen(string n, int max, double rs)
        {
            name = n;
            maxAnzahl = Math.Abs(max);
            listeSchnecken = new Schnecke[maxAnzahl];       // Deklaration und Speicherreservierung der Schnecken
            rennStrecke = Math.Abs(rs);
            anzahl = 0;
        }
        /// <summary>
        /// Fügt eine Schnecke dem Renne hinzu
        /// </summary>
        /// <param name="sch">Die Schnegge</param>
        /// <returns>True, wenn die Schnecke hinzugefügt werden konnte, false ansonsten</returns>
        public bool addSchnecke(Schnecke sch)
        {
            if (anzahl >= maxAnzahl)
            {
                Console.WriteLine("The race is already complete!");
                return false;
            }
            bool schonDabei = false;
            for (int i = 0; i < anzahl; i++)
            {
                if (listeSchnecken[i].name == sch.name)
                    schonDabei = true;
            }
            if (schonDabei)
            {
                Console.WriteLine("This snail is alredy at this race!");
                return false;
            }
            else
            {
                listeSchnecken[anzahl] = sch;
                anzahl++;
            }
            return true;
        }
        /// <summary>
        /// Ausgabe der Infos zum Rennen (inklusive Liste der Schnecken)
        /// </summary>
        /// <returns>Alle Infos zum Renne</returns>
        public string toString()
        {
            string s = this.name + ": " + anzahl + " von " + maxAnzahl + " Schnecken\n";
            s += " - Teilnehmer:\n";
            for (int i = 0; i < anzahl; i++)
            {
                s += listeSchnecken[i].toString()+"\n";
            }
            return s;
        }
        /// <summary>
        /// Ermittelt den Gewinner des Rennens
        /// </summary>
        /// <returns>Die erste Schnecke, die die Rennstrecke zurückgelegt hat oder null, wenn es noch keine geschafft hat </returns>
        public Schnecke ermittleGewinner()
        {
            bool einSieger = false;
            for (int i = 0; i <anzahl; i++)
            {
                if (listeSchnecken[i].strecke >= rennStrecke)
                    einSieger=true;
            }
            if (einSieger)
            {
                Schnecke beste = this.listeSchnecken[0];
                for (int i = 0; i < anzahl; i++)
                {
                    if (beste.strecke < listeSchnecken[i].strecke)
                        beste = listeSchnecken[i];
                }
                return beste;
            }
            return null;
        }
        /// <summary>
        /// Lässt alle Schnecken einmal kriechen...
        /// </summary>
        void lasseSchneckenKriechen()
        {
            for (int i = 0; i < anzahl; i++)
            {
                listeSchnecken[i].kriechen();
            }
        }
        /// <summary>
        /// Lässt alle Schnecken kriechen, bis eine gewonnen hat!
        /// </summary>
        public void durchfuehren()
        {
            while (ermittleGewinner() == null)
                lasseSchneckenKriechen();
        }

    }
}
