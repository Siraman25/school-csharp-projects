using System;
using System.Collections;
using System.IO;

namespace Uebung27_CSVEinlesesn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "/home/aris/C#/Uebung27_CSVEinlesesn/20201216.csv";
                StreamReader lesenFile = new StreamReader(path);
                ArrayList liste1 = new ArrayList();

                while (!lesenFile.EndOfStream)
                {
                    liste1.Add(lesenFile.ReadLine());
                }

                liste1.RemoveAt(0);
                liste1.RemoveAt(0);

                // foreach (var listeEinzeln in liste1)
                // {
                //     Console.WriteLine(listeEinzeln);
                // }

                string[] array1 = new string[liste1.Count];

                int i = 0;
                foreach (var element in liste1)
                {
                    array1[i] = Convert.ToString(element);
                    i++;
                }

                // foreach (var elementOutput in array1)
                // {
                //     Console.WriteLine(elementOutput);
                // }

                string[,] array2 = new string[13, array1.Length];
                i = 0;
                foreach (var element2 in array1)
                {
                    string[] array2dot1 = Convert.ToString(element2).Split(";");
                    for (int j = 0; j < 13; j++)
                    {
                        array2[j, i] = array2dot1[j];
                    }

                    i++;
                }

                // Console.WriteLine("Finished");


                double[,] arrayWithDouble = new double[array2.GetLength(0)-2, array2.GetLength(1)];

                for (int j = 0; j < arrayWithDouble.GetLength(1); j++) // Höhe des Arrays
                {
                    for (int k = 0; k < arrayWithDouble.GetLength(0); k++) //Breite des Arrays
                    {
                        arrayWithDouble[k, j] = Convert.ToDouble(array2[k + 2, j]);

                    }
                }

                // Console.WriteLine("Finished2");

                for (int j = 0; j < arrayWithDouble.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayWithDouble.GetLength(0); k++)
                    {
                        Console.Write(arrayWithDouble[k, j] + "; ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Starting median creation");

                double Median;
                for (int j = 0; j < arrayWithDouble.GetLength(0); j++)
                {
                    Median = 0;
                    for (int k = 0; k < arrayWithDouble.GetLength(1); k++)
                    {
                        Median = Median + arrayWithDouble[j, k];
                    }

                    Median = Median / arrayWithDouble.GetLength(1);

                    Console.WriteLine("Median column {0}: {1}", j+1, Median);
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine("Unhandled exception: " + exc);
            }
        }
    }
}