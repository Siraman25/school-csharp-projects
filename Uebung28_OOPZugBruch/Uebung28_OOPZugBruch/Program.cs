using System;
using System.Collections.Generic;
using System.Linq;

namespace Uebung28_OOPZugBruch
{
    class Train
    {
        public string anzahl_wagons;
        public string anzahl_sitzplätze;
        public string name;
        public string zugnummer;
        public string preis;
        public Dictionary<string, string> fahrplan = new Dictionary<string, string>();

        public string get_info()
        {
            string output = "Zugnahme: " + name + "\nZugnummer: " + zugnummer + "\nTicketpreis: " + preis + "\nAnzahl Wagons: " + anzahl_wagons + "\nAnzahl Sitzplätze: " + anzahl_sitzplätze;
            return output;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Train MeranBozen = new Train();

            MeranBozen.anzahl_wagons = "4";
            MeranBozen.anzahl_sitzplätze = "104";
            MeranBozen.name = "Meran - Bozen";
            MeranBozen.zugnummer = "200";
            MeranBozen.preis = "5 Euro";
            MeranBozen.fahrplan.Add("Meran", "7:13");
            MeranBozen.fahrplan.Add("Meran-Untermais", "7:17");
            MeranBozen.fahrplan.Add("Lana-Burgstall", "7:23");
            MeranBozen.fahrplan.Add("Gargazon", "7:28");
            MeranBozen.fahrplan.Add("Vilpian-Nals", "7:32");
            MeranBozen.fahrplan.Add("Terlan-Andrian", "7:37");
            MeranBozen.fahrplan.Add("Siebeneich", "7:40");
            MeranBozen.fahrplan.Add("Siegmundskron", "7:46");
            MeranBozen.fahrplan.Add("Bozen Kaiserau", "7:49");
            MeranBozen.fahrplan.Add("Bozen Süd", "7:52");
            MeranBozen.fahrplan.Add("Bozen", "8:00");

            Console.WriteLine(MeranBozen.get_info());
            

            int zug_status = 1;
            while (zug_status < 12)
            {
                switch (zug_status)
                {
                    case 1:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(0).Key,
                            MeranBozen.fahrplan.ElementAt(0).Value);
                        break;
                    case 2:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(1).Key,
                            MeranBozen.fahrplan.ElementAt(1).Value);
                        break;
                    case 3:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(2).Key,
                            MeranBozen.fahrplan.ElementAt(2).Value);
                        break;
                    case 4:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(3).Key,
                            MeranBozen.fahrplan.ElementAt(3).Value);
                        break;
                    case 5:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(4).Key,
                            MeranBozen.fahrplan.ElementAt(4).Value);
                        break;
                    case 6:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(5).Key,
                            MeranBozen.fahrplan.ElementAt(5).Value);
                        break;
                    case 7:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(6).Key,
                            MeranBozen.fahrplan.ElementAt(6).Value);
                        break;
                    case 8:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(7).Key,
                            MeranBozen.fahrplan.ElementAt(7).Value);
                        break;
                    case 9:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(8).Key,
                            MeranBozen.fahrplan.ElementAt(8).Value);
                        break;
                    case 10:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(9).Key,
                            MeranBozen.fahrplan.ElementAt(9).Value);
                        break;
                    case 11:
                        Console.WriteLine("Der Zug Befindet sich in {0} um {1}", MeranBozen.fahrplan.ElementAt(10).Key,
                            MeranBozen.fahrplan.ElementAt(10).Value);
                        Console.WriteLine("Sie sind angekommen.");
                        break;
                    default:
                        Console.WriteLine("How the fuck did you get here.");
                        break;
                }
                Console.WriteLine("Drücken Sie eine Taste zum fortfahren.");
                Console.ReadKey();
                zug_status++;
            }
        }
    }
}