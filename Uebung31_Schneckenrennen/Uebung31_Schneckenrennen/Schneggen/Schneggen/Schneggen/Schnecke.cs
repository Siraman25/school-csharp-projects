using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schneggen
{
    class Schnecke
    {
        public string name;         // Name der Schnegge
        public string rasse;        // Rasse der Schnegge
        public double maxSpeed;     // in cm/min
        public double strecke;      // zurückgelegte Strecke in cm
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="n">Name der Schnecke</param>
        /// <param name="r">Rasse der Schnecke</param>
        /// <param name="m">Höchstgeschwindigkeit der Schnecke in cm/min</param>
        public Schnecke(string n, string r, double m)
        {
            name = n;
            rasse = r;
            maxSpeed = m>0?m:0;
            strecke = 0;
        }
        /// <summary>
        /// Die Schnegge kriecht eine zufällige Strecke in einer Zeiteinheit (Minute) gemäss ihrer maxSpeed 
        /// Die zurückgelegte Strecke wird aktualisiert
        /// </summary>
        public void kriechen()
        {
            Random rnd = new Random();
            int tempspeed = (int)(maxSpeed * 100);
            double zz = rnd.Next(tempspeed) / 100.0 ;
            strecke += zz;
        }
        /// <summary>
        /// Ausgabe der Infos zur Schnecke als string
        /// </summary>
        /// <returns>Zeichenkette mit Infos zur Schnegge</returns>
        public string toString()
        {
            return name + "\t/\t" + rasse + ", \tMax.: " + maxSpeed + ": \t@ " + strecke + "cm";
        }
    }
}
