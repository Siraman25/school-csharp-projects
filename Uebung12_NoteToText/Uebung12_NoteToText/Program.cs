using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung12_NoteToText
{
    class Program
    {
        static void Main(string[] args)
        {
            double noteZiffer;
            Console.Write("Gebe eine Note ein: ");
            noteZiffer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(NoteTextBerechnung(noteZiffer));
            Console.ReadKey();
        }
        /*
         * NoteTextBerechnung
         * Rundet die Note und gibt Text aus.
         * 
         * von Aris
         * Input: Double; Ziffer der Note
         * Output: String; Text der Note
        */


        public static string NoteTextBerechnung(double note)
        {
            int noteGerundet;
            string ausgabe = "";
            noteGerundet = (Int32)Math.Round(note, 0, MidpointRounding.AwayFromZero);
            switch (noteGerundet)
            {
                case 10:
                    ausgabe = "Ausgezeichnet!";
                    break;
                case 9:
                    ausgabe = "Sehr gut";
                    break;
                case 8:
                    ausgabe = "Gut";
                    break;
                case 7:
                    ausgabe = "Zufriedenstellend";
                    break;
                case 6:
                    ausgabe = "Genügend";
                    break;
                case 5:
                    ausgabe = "Ungenügend";
                    break;
                case 4:
                    ausgabe = "Völlig ungenügend";
                    break;
                default:
                    ausgabe = "Fehler!";
                    break;

            }
            return ausgabe;
        }

        public static string NoteTextBerechnung2(double note)
        {
            int noteGerundet;
            noteGerundet = (Int32)Math.Round(note, 0, MidpointRounding.AwayFromZero);
            if (noteGerundet == 10)
            {
                return "Ausgezeichnet!";
            }
            else if (noteGerundet == 9)
            {
                return "Sehr gut";
            }
            else if (noteGerundet == 8)
            {
                return "Gut";
            }
            else if (noteGerundet == 7)
            {
                return "Zufriedenstellend";
            }
            else if (noteGerundet == 6)
            {
                return "Genügend";
            }
            else if (noteGerundet == 5)
            {
                return "Ungenügend";
            }
            else if (noteGerundet == 4)
            {
                return "Völlig ungenügend";
            }
            else
            {
                return "Fehler!";
            }
        }
    }
}
