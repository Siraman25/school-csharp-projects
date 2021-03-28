using System;

namespace Uebung31_Schneckenrennen
{
    public class Schnecke
    {
        private string name_schnecke;
        private string startnummer_schnecke;
        private string farbe_schnecke;
        private int punkt = 0;
        private int tot_punkt = 0;

        public string schnecke_icon1 = @".----. @ @";
        public string schnecke_icon2 = @"/ .-""-.`. \v/";
        public string schnecke_icon3 = @"| | '\\ \\ \\_/ )";
        public string schnecke_icon4 = @",-\\ `-.' /.' /";
        public string schnecke_icon5 = @"'---`----'----'\";

        public void reset()
        {
            this.punkt = 0;
            this.tot_punkt = 0;
        }
        public void setSchneckeInfo(string name, string startnummer, string farbe)
        {
            this.name_schnecke = name;
            this.startnummer_schnecke = startnummer;
            this.farbe_schnecke = farbe;
        }
        public string getSchneckeName()
        {
            Console.WriteLine(this.name_schnecke);
            return this.name_schnecke;
        }

        public int rennenNext()
        {
            Random punkt_calc = new Random();
            this.punkt = punkt_calc.Next(1, 11);
            this.tot_punkt = this.tot_punkt + this.punkt;
            return tot_punkt;
        }
    }

    class Program
    {
        static void print_men()
        {
            Console.WriteLine("1 - Schnecke Hinzufügen");
            Console.WriteLine("2 - Rennen starten");
            Console.WriteLine("3 - Beenden");
        }

        static void Main(string[] args)
        {
            int anzahl = 0;
            int status = 0;
            string name_schnecke;
            string startnummer_schnecke;
            string farbe_schnecke;

            Schnecke schnecke_1 = new Schnecke();
            Schnecke schnecke_2 = new Schnecke();
            Schnecke schnecke_3 = new Schnecke();
            Schnecke schnecke_4 = new Schnecke();
            
            while (true)
            {
                schnecke_1.reset();
                schnecke_2.reset();
                schnecke_3.reset();
                schnecke_4.reset();
                
                print_men();
                try
                {
                    status = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren...");
                    Console.ReadKey();
                }

                switch (status)
                {
                    case 1:
                        switch (anzahl)
                        {
                            case 0:
                                Console.Write("Namen der Schnecke: ");
                                name_schnecke = Console.ReadLine();
                                Console.Write("Startnummer der Schnecke: ");
                                startnummer_schnecke = Console.ReadLine();
                                Console.Write("Farbe der Schnecke: ");
                                farbe_schnecke = Console.ReadLine();
                                schnecke_1.setSchneckeInfo(name_schnecke, startnummer_schnecke, farbe_schnecke);
                                anzahl++;
                                break;
                            case 1:
                                Console.Write("Namen der Schnecke: ");
                                name_schnecke = Console.ReadLine();
                                Console.Write("Startnummer der Schnecke: ");
                                startnummer_schnecke = Console.ReadLine();
                                Console.Write("Farbe der Schnecke: ");
                                farbe_schnecke = Console.ReadLine();
                                schnecke_2.setSchneckeInfo(name_schnecke, startnummer_schnecke, farbe_schnecke);
                                anzahl++;
                                break;
                            case 2:
                                Console.Write("Namen der Schnecke: ");
                                name_schnecke = Console.ReadLine();
                                Console.Write("Startnummer der Schnecke: ");
                                startnummer_schnecke = Console.ReadLine();
                                Console.Write("Farbe der Schnecke: ");
                                farbe_schnecke = Console.ReadLine();
                                schnecke_3.setSchneckeInfo(name_schnecke, startnummer_schnecke, farbe_schnecke);
                                anzahl++;
                                break;
                            case 3:
                                Console.Write("Namen der Schnecke: ");
                                name_schnecke = Console.ReadLine();
                                Console.Write("Startnummer der Schnecke: ");
                                startnummer_schnecke = Console.ReadLine();
                                Console.Write("Farbe der Schnecke: ");
                                farbe_schnecke = Console.ReadLine();
                                schnecke_4.setSchneckeInfo(name_schnecke, startnummer_schnecke, farbe_schnecke);
                                anzahl++;
                                break;
                            default:
                                Console.WriteLine("Maximale Anzahl an Teilnehmer erreicht!");
                                break;
                        }

                        break;
                    case 2:
                        int punkteanzahl = 0;
                        int punkte1 = 0;
                        int punkte2 = 0;
                        int punkte3 = 0;
                        int punkte4 = 0;
                        bool breakloop = false;

                        while (punkteanzahl < 101)
                        {
                            Console.Clear();
                            if (anzahl == 1 || anzahl == 2 || anzahl == 3 || anzahl == 4)
                            {
                                punkte1 = schnecke_1.rennenNext();
                                Console.SetCursorPosition(punkte1, 0);
                                Console.WriteLine(schnecke_1.schnecke_icon1);
                                Console.SetCursorPosition(punkte1, 1);
                                Console.WriteLine(schnecke_1.schnecke_icon2);
                                Console.SetCursorPosition(punkte1, 2);
                                Console.WriteLine(schnecke_1.schnecke_icon3);
                                Console.SetCursorPosition(punkte1, 3);
                                Console.WriteLine(schnecke_1.schnecke_icon4);
                                Console.SetCursorPosition(punkte1, 4);
                                Console.WriteLine(schnecke_1.schnecke_icon5);
                                if (punkte1 >= punkteanzahl)
                                {
                                    punkteanzahl = punkte1;
                                }
                            }

                            if (anzahl == 2 || anzahl == 3 || anzahl == 4)
                            {
                                punkte2 = schnecke_2.rennenNext();
                                Console.SetCursorPosition(punkte2, 6);
                                Console.WriteLine(schnecke_2.schnecke_icon1);
                                Console.SetCursorPosition(punkte2, 7);
                                Console.WriteLine(schnecke_2.schnecke_icon2);
                                Console.SetCursorPosition(punkte2, 8);
                                Console.WriteLine(schnecke_2.schnecke_icon3);
                                Console.SetCursorPosition(punkte2, 9);
                                Console.WriteLine(schnecke_2.schnecke_icon4);
                                Console.SetCursorPosition(punkte2, 10);
                                Console.WriteLine(schnecke_2.schnecke_icon5);
                                if (punkte2 >= punkteanzahl)
                                {
                                    punkteanzahl = punkte2;
                                }
                            }
                            if (anzahl == 3 || anzahl == 4)
                            {
                                punkte3 = schnecke_3.rennenNext();
                                Console.SetCursorPosition(punkte3, 12);
                                Console.WriteLine(schnecke_3.schnecke_icon1);
                                Console.SetCursorPosition(punkte3, 13);
                                Console.WriteLine(schnecke_3.schnecke_icon2);
                                Console.SetCursorPosition(punkte3, 14);
                                Console.WriteLine(schnecke_3.schnecke_icon3);
                                Console.SetCursorPosition(punkte3, 15);
                                Console.WriteLine(schnecke_3.schnecke_icon4);
                                Console.SetCursorPosition(punkte3, 16);
                                Console.WriteLine(schnecke_3.schnecke_icon5);
                                if (punkte3 >= punkteanzahl)
                                {
                                    punkteanzahl = punkte3;
                                }
                            }
                            if (anzahl == 4)
                            {
                                punkte4 = schnecke_4.rennenNext();
                                Console.SetCursorPosition(punkte4, 18);
                                Console.WriteLine(schnecke_4.schnecke_icon1);
                                Console.SetCursorPosition(punkte4, 19);
                                Console.WriteLine(schnecke_4.schnecke_icon2);
                                Console.SetCursorPosition(punkte4, 20);
                                Console.WriteLine(schnecke_4.schnecke_icon3);
                                Console.SetCursorPosition(punkte4, 21);
                                Console.WriteLine(schnecke_4.schnecke_icon4);
                                Console.SetCursorPosition(punkte4, 22);
                                Console.WriteLine(schnecke_4.schnecke_icon5);
                                if (punkte4 >= punkteanzahl)
                                {
                                    punkteanzahl = punkte4;
                                }
                            }
                            if (anzahl == 0)
                            {
                                Console.WriteLine("Fehler: Nicht genügende Spieler.");
                                punkteanzahl = 500;
                            }

                            Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren.");
                            Console.ReadKey();
                        }
                        if (punkte1 == punkteanzahl)
                            
                        {
                            Console.WriteLine("Schnecke " + schnecke_1.getSchneckeName() + " gewinnt!");
                        }
                        else if (punkte2 == punkteanzahl)
                        {
                            Console.WriteLine("Schnecke " + schnecke_2.getSchneckeName() + " gewinnt!");
                        }
                        else if (punkte3 == punkteanzahl)
                        {
                            Console.WriteLine("Schnecke " + schnecke_3.getSchneckeName() + " gewinnt!");
                        }
                        else if (punkte4 == punkteanzahl)
                        {
                            Console.WriteLine("Schnecke " + schnecke_4.getSchneckeName() + " gewinnt!");
                        }
                        else if (punkteanzahl == 500)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Fehler.");
                        }

                        Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren.");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Fehler: Keine Nummer von 1-3 gewählt.");
                        break;
                }
            }
        }
    }
}