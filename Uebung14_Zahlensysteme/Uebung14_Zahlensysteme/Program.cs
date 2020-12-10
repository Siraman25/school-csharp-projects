using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung14_Zahlensysteme
{
    class Program
    {
        /*
         * Main:
         * Aris Mandolini
         * 29/10/2020
         * 
         * Wählt die richtige Funktion aus.
         */
        static void Main(string[] args)
        {
            int AuswahlMenVar = 0;
            int InputBerechnung = 0;
            int OutputBerechnung = 0;
            string InputBerechnungString = " ";
            string OutputBerechnungString = " ";
            
            do
            {
                Console.Clear();
                AuswahlMen();
                AuswahlMenVar = Convert.ToInt32(Console.ReadLine());

            } while (AuswahlMenVar < 1 || AuswahlMenVar > 7);
            
            
            switch (AuswahlMenVar)
            {
                case 1:
                    Console.Write("Gebe deine Zahl in DEC ein:");
                    InputBerechnung = Convert.ToInt32(Console.ReadLine());
                    OutputBerechnung = Convert.ToInt32(BerechnungDecToBin(InputBerechnung));
                    Console.WriteLine("Deine Zahl DEC " + InputBerechnung + " ist " + OutputBerechnung + " in BIN.");
                    break;
                case 2:
                    Console.Write("Gebe deine Zahl in DEC ein:");
                    InputBerechnung = Convert.ToInt32(Console.ReadLine());
                    OutputBerechnungString = BerechnungDecToHex(InputBerechnung);
                    Console.WriteLine("Deine Zahl DEC " + InputBerechnung + " ist " + OutputBerechnungString + " in HEX.");
                    break;
                case 3:
                    Console.Write("Gebe deine Zahl in BIN ein:");
                    InputBerechnungString = Console.ReadLine();
                    OutputBerechnung = BerechnungBinToDec(InputBerechnungString);
                    Console.WriteLine("Deine Zahl BIN " + InputBerechnungString + " ist " + OutputBerechnung + " in DEC.");
                    break;
                case 4:
                    Console.Write("Gebe deine Zahl in BIN ein:");
                    InputBerechnungString = Console.ReadLine();
                    OutputBerechnungString = BerechnungBinToHex(InputBerechnungString);
                    Console.WriteLine("Deine Zahl BIN " + InputBerechnungString + " ist " + OutputBerechnungString + " in HEX.");
                    break;
                case 5:
                    Console.Write("Gebe deine Zahl in HEX ein:");
                    InputBerechnungString = Console.ReadLine();
                    OutputBerechnung = BerechnungHexToDec(InputBerechnungString);
                    Console.WriteLine("Deine Zahl HEX " + InputBerechnungString + " ist " + OutputBerechnung + " in DEC.");
                    break;
                case 6:
                    Console.Write("Gebe deine Zahl in HEX ein:");
                    InputBerechnungString = Console.ReadLine();
                    OutputBerechnungString = BerechnungHexToBin(InputBerechnungString);
                    Console.WriteLine("Deine Zahl HEX " + InputBerechnungString + " ist " + OutputBerechnungString + " in BIN.");
                    break;
                case 7:
                    Console.WriteLine("Drücken Sie eine beliebige Taste zum Beenden.");
                    Console.ReadKey();
                    System.Environment.Exit(1);
                    break;
                default:
                    break;

            }
            Console.ReadKey();

        }

        /*
         * AsuwahlMen:
         * Aris Mandolini
         * 29/10/2020
         * 
         * Gibt die Verschidenen Möglichkeiten an.
         */
        public static void AuswahlMen()
        {
            Console.WriteLine("Wähle eine Konversion aus:");
            Console.WriteLine("1 - Dec -> Bin");        //Input: Int Output: String
            Console.WriteLine("2 - Dec -> Hex");        //Input: Int Output: String
            Console.WriteLine("3 - Bin -> Dec");        //Input: String Output: Int
            Console.WriteLine("4 - Bin -> Hex");        //Input: String Output: String
            Console.WriteLine("5 - Hex -> Dec");        //Input: String Output: Int
            Console.WriteLine("6 - Hex -> Bin");        //Input: String Output: String
            Console.WriteLine("7 - Beenden");
            Console.Write("Input: ");
        }



        /*
         * Autor:Ladurner_Juri
         */
        public static string BerechnungDecToBin2(int Dec)
        {
            //ToDo: Rechner ohne Convert
            string Binaer = Convert.ToString(Dec, 2);
            Binaer = Binaer.PadLeft(4, '0');
            return Binaer;
        }
        /*
         * Autor:Ladurner_Juri
         */
        public static string BerechnungDecToHex(int Dec)
        {
            string Hex = Dec.ToString("X");
            return Hex;
        }
        /*
         * Autor:Ladurner_Juri
         */
        public static int BerechnungBinToDec(string Binaer)
        {
            int Dec = Convert.ToInt32(Binaer, 2);
            return Dec;
        }
        /*
         * Autor:Ladurner_Juri
         */
        public static string BerechnungBinToHex(string Bin)
        {
            string Hex = Convert.ToInt32(Bin, 2).ToString("X");
            return Hex;
        }
        /*
         * Autor:Ladurner_Juri
         */
        public static int BerechnungHexToDec(string Hex)
        {
            int Dec = Convert.ToInt32(Hex, 16);
            return Dec;
        }
        /*
         * Autor:Ladurner_Juri
         */
        public static string BerechnungHexToBin(string Hex)
        {
            string Bin = Convert.ToString(Convert.ToInt32(Hex, 16), 2);
            return Bin;
        }

        public static string BerechnungDecToBin(int Dec)
        {
            int Bin;
            string Merker = "";
            while (Dec >= 1)
            {
                Bin = Dec / 2;
                Merker = Merker + (Dec % 2).ToString();
                Dec = Bin;
            }
            string BinErgebnis = "";
            for (int i = Merker.Length - 1; i >= 0; i = i-1)
            {
                BinErgebnis = BinErgebnis + Merker[i];
            }
            return BinErgebnis;
        }

    }
}
