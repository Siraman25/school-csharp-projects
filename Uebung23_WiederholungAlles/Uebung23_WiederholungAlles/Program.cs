using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Uebung23_WiederholungAlles
{
    class Program
    {
        public static double[] ArrayPopulation()
        {
            const int MAXARR = 1002;
            double[] Array1 = new double[MAXARR];
            Array1[MAXARR - 2] = 0;
            Array1[MAXARR - 1] = MAXARR;
            return Array1;
        }
        public static void Menue(int MaxDimension, int CurrentDimension)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Das Feld hat eine Grösse von {0}, wir haben aber erst {1} Messwerte erfasst.", MaxDimension - 2, CurrentDimension);
            Console.WriteLine("Bitte wählen sie eine der folgenden Optionen");
            Console.WriteLine("1. Zusätzlichen Messwert erfassen");
            Console.WriteLine("2. Letzten Messwert löschen"); 
            Console.WriteLine("3. Mittelwert berechnen und ausgeben");
            Console.WriteLine("4. Daten in Datei schreiben");
            Console.WriteLine("5. Daten von Datei lesen");
            Console.WriteLine("6. Programm beenden");
            Console.Write("Wahl: ");
        }
        public static void ZusatzWert(ref double[] Array1)
        {
            try
            {
                int MaxDimension = Convert.ToInt32(Array1[1001]);
                int CurrentDimension = Convert.ToInt32(Array1[MaxDimension - 2]);
                Console.Write("Geben Sie den Wert ein: ");
                double input = Convert.ToDouble(Console.ReadLine());
                Array1[CurrentDimension] = input;
                Array1[MaxDimension - 2]++;
                Console.WriteLine("Abgeschlossen. Drücken Sie eine beliebige Taste zum Fortfahren.");
                Console.ReadKey();
            }
            catch (Exception exception)
            {

                Console.WriteLine("Fehler: " + exception);
                Console.ReadKey();
            }
        }
        public static void WertLoeschen(ref double[] Array1)
        {
            try
            {
                int MaxDimension = Convert.ToInt32(Array1[1001]);
                int CurrentDimension = Convert.ToInt32(Array1[MaxDimension - 2]);
                if (Array1[CurrentDimension - 1] == 0)
                {
                    Console.WriteLine("Der Array ist leer.");
                    Console.WriteLine("Keine Daten wurden geändert. Drücken Sie eine beliebige Taste zum Fortfahren.");
                }
                else
                {
                    Array1[CurrentDimension] = 0;
                    Array1[MaxDimension - 2]--;
                    Console.WriteLine("Abgeschlossen. Drücken Sie eine beliebige Taste zum Fortfahren.");
                }
                Console.ReadKey();
            }
            catch (Exception exception)
            {

                Console.WriteLine("Fehler: " + exception);
                Console.ReadKey();
            }
        }
        public static void Mittelwert(ref double[] Array1)
        {
            try
            {
                int MaxDimension = Convert.ToInt32(Array1[1001]);
                int CurrentDimension = Convert.ToInt32(Array1[MaxDimension - 2]);
                if (Array1[CurrentDimension - 1] == 0)
                {
                    Console.WriteLine("Der Array ist leer.");
                    Console.WriteLine("Keine Daten wurden geändert. Drücken Sie eine beliebige Taste zum Fortfahren.");
                }
                else
                {
                    double MittelwertZahl = 0;
                    for (int i = 0; i < CurrentDimension; i++)
                    {
                        MittelwertZahl = MittelwertZahl + Array1[i];
                    }
                    MittelwertZahl = MittelwertZahl / CurrentDimension;
                    Console.WriteLine("Der Mittelwert beträgt " + MittelwertZahl + ".");
                    Console.WriteLine("Abgeschlossen. Drücken Sie eine beliebige Taste zum Fortfahren.");
                }
                Console.ReadKey();
            }
            catch (Exception exception)
            {

                Console.WriteLine("Fehler: " + exception);
                Console.ReadLine();
            }
        }
        public static void saveToFile(ref double[] Array1)
        {
            try
            {
                int MaxDimension = Convert.ToInt32(Array1[1001]);
                int CurrentDimension = Convert.ToInt32(Array1[MaxDimension - 2]);

                Console.Write("Wie möchten Sie Ihr file nennen? ");
                string fileName = Console.ReadLine();
                string path = "J:\\TFO Meran Oskar von Miller\\Schulefiles\\3BEL\\Automation\\C#\\Uebung23_WiederholungAlles\\Uebung23_WiederholungAlles\\" + fileName + ".txt";
                Console.WriteLine("File-Pfad: " + path);

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                FileStream createNewFile = File.Create(path);
                createNewFile.Close();

                StreamWriter writeToFile = new StreamWriter(path);
                for (int i = 0; i < CurrentDimension; i++)
                {
                    writeToFile.WriteLine(Array1[i]);
                }
                writeToFile.Close();
                Console.WriteLine("Abgeschlossen. Drücken Sie eine beliebige Taste zum Fortfahren.");
                Console.ReadKey();
            }
            catch (Exception exception)
            {

                Console.WriteLine("Fehler: " + exception);
                Console.ReadKey();
            }
        }
        public static void readFromFile(ref double[] Array1)
        {
            try
            {
                int MaxDimension = Convert.ToInt32(Array1[1001]);
                int CurrentDimension = Convert.ToInt32(Array1[MaxDimension - 2]);

                Console.Write("Wie heißt Ihr file? ");
                string fileName = Console.ReadLine();
                string path = "J:\\TFO Meran Oskar von Miller\\Schulefiles\\3BEL\\Automation\\C#\\Uebung23_WiederholungAlles\\Uebung23_WiederholungAlles\\" + fileName + ".txt";
                Console.WriteLine("File-Pfad: " + path);

                StreamReader readFromFile = new StreamReader(path);
                int j = 0;
                for (int i = 0; i < CurrentDimension; i++)
                {
                    Array1[i] = 0;
                }
                Array1[MaxDimension - 2] = 0;
                while (!readFromFile.EndOfStream)
                {
                    Array1[j] = Convert.ToDouble(readFromFile.ReadLine());
                    j++;
                    Array1[MaxDimension - 2]++;
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine("Fehler: " + exception);
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            double[] MainArray = ArrayPopulation();
            while (true)
            {
                try
                {

                    Menue(Convert.ToInt32(MainArray[1001]), Convert.ToInt32(MainArray[1000]));      // 1001 = MaxDimension (1002); 1000 = CurrentDimension (0)
                    int selector = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();

                    switch (selector)
                    {
                        case 1:
                            ZusatzWert(ref MainArray);
                            break;
                        case 2:
                            WertLoeschen(ref MainArray);
                            break;
                        case 3:
                            Mittelwert(ref MainArray);
                            break;
                        case 4:
                            saveToFile(ref MainArray);
                            break;
                        case 5:
                            readFromFile(ref MainArray);
                            break;
                        case 6:
                            System.Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Fehler: " + exception);
                    Console.ReadKey();
                }
            }
        }
    }
}
