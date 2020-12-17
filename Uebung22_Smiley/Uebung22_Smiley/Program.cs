using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Uebung22_Smiley
{
    class Program
    {
        public static void PrintBitmap(int[,] result)
        {
            for (int k = 0; k < 20; k++)
            {
                for (int l = 0; l < 20; l++)
                {
                    if (result[k, l] == 1)
                    {
                        Console.SetCursorPosition(l, k);
                        Console.WriteLine("1");
                    }
                }
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string path = "H:\\TFO Meran Oskar von Miller\\Schulefiles\\3BEL\\Automation\\C#\\Uebung22_Smiley\\Uebung22_Smiley\\smiley.bmp";
            StreamReader readBMP = new StreamReader(path);
            string input = readBMP.ReadToEnd();
            int i = 0, j = 0;
            int[,] result = new int[20, 20];
            foreach (string row in input.Split('\n'))
            {
                j = 0;
                foreach (string col in row.Split(','))
                {
                    result[i, j] = Convert.ToInt32((col));
                    j++;
                }
                i++;
            }
            PrintBitmap(result);
        }
    }
}
