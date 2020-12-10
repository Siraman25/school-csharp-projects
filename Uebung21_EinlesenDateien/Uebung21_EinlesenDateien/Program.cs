using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Uebung21_EinlesenDateien
{
    class Program
    {
        public static double[] readFile(string filePath)
        {
            try
            {
                StreamReader textStream = new StreamReader(filePath);
                int i = 0;
                while (textStream.ReadLine() != null) { i++; ; }
                double[] readerArray = new double[46];
                textStream.BaseStream.Seek(0, SeekOrigin.Begin);

                int n = 0;
                while (!textStream.EndOfStream)
                {
                    readerArray[n] = Convert.ToDouble(textStream.ReadLine()); n++;
                }
                textStream.Close();
                return readerArray;
            }
            catch (Exception ex)
            {
                double[] readerArray = new double[1];
                Console.WriteLine("ERROR! ID: " + ex);
                return readerArray;
            }
        }
        public static void printout(double[] arrayPrint)
        {
            for (int i = 0; i < arrayPrint.Length; i++)
            {
                Console.WriteLine(arrayPrint[i]);
            }
        }
        public static double mean(double[] arrayPrint)
        {
            double meanValue = 0;
            for (int i = 0; i < arrayPrint.Length; i++)
			{
                meanValue = meanValue + arrayPrint[i];
			}
            meanValue = meanValue / arrayPrint.Length;
            return meanValue;
        }
        public static double[] doubleArray(double[] arrayPrint)
        {
            double[] doubledArray = new double[arrayPrint.Length];
            for (int i = 0; i < arrayPrint.Length; i++)
            {
                doubledArray[i] = arrayPrint[i] * 2;
            }
            return doubledArray;
        }
        public static void halfByRef(ref double[] halfByReferenceArray, int x)
        {
            for (int i = 0; i < halfByReferenceArray.Length; i = i + x)
            {
                halfByReferenceArray[i] = halfByReferenceArray[i] / 2;
            }
        }

        static void Main(string[] args)
        {
            string filePath = "J:\\TFO Meran Oskar von Miller\\Schulefiles\\3BEL\\Automation\\C#\\Uebung21_EinlesenDateien\\Uebung21_EinlesenDateien\\pm10onlyvalues_de.txt";
            Console.WriteLine("Print array:");
            printout(readFile(filePath));
            Console.WriteLine("Print mean:");
            Console.WriteLine(mean(readFile(filePath)));
            Console.WriteLine("Print doubled:");
            printout(doubleArray(readFile(filePath)));

            double[] halfByReferenceArray = new double[readFile(filePath).Length];
            Console.Write("Write x-reference: ");
            int x = Convert.ToInt32(Console.ReadLine());
            halfByReferenceArray = readFile(filePath);
            halfByRef(ref halfByReferenceArray, x);
            Console.WriteLine("Array with x-ref:");
            printout(halfByReferenceArray);
            Console.ReadKey();
        }
    }
}
