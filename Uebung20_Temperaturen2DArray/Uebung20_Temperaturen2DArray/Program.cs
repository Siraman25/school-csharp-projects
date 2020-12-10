﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung20_Temperaturen2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] temp = {
  {8.8,7.8,15.9,17.3,20.4,28.0,33.0,26.5,23.4,17.9,10.5,5.9,18.0},
  {5.6,7.0,12.2,18.1,17.7,25.8,29.0,26.0,20.7,17.1,10.6,5.3,16.3},
  {0.5,7.6,10.2,17.3,21.3,24.2,29.2,28.0,26.3,19.8,7.6,6.8,16.6},
  {4.0,4.8,13.0,14.0,25.8,27.0,28.4,27.8,24.0,19.9,11.5,5.9,17.2},
  {4.4,7.4,11.6,20.8,21.4,25.8,29.5,28.8,26.8,17.2,12.4,8.4,17.9},
  {6.9,9.7,13.4,19.7,22.9,25.5,28.9,28.7,24.8,19.4,10.4,9.3,18.3},
  {9.0,10.9,16.9,15.0,23.5,24.6,26.9,27.9,23.6,19.4,10.0,6.4,17.8},
  {6.7,11.6,18.2,16.6,24.6,24.8,29.0,28.5,23.0,18.2,10.1,4.1,18.0},
  {6.2,6.9,15.0,18.5,19.5,26.0,30.7,30.0,25.2,16.6,9.6,6.5,17.6},
  {7.1,11.0,14.5,17.0,24.1,24.7,28.0,30.1,22.5,13.9,11.4,6.0,17.5},
  {6.5,10.4,14.5,20.1,24.0,26.2,26.8,28.5,20.3,15.2,9.9,6.0,17.4},
  {7.2,8.2,18.5,16.9,22.2,26.4,30.2,29.1,22.6,17.2,12.9,7.5,18.2},
  {4.8,10.2,12.4,18.2,21.8,23.6,30.0,24.7,20.0,21.5,11.0,5.6,17.0},
  {6.3,8.9,13.5,20.4,24.1,29.6,29.1,27.3,22.0,17.2,11.9,5.7,18.0},
  {7.6,12.0,19.0,19.6,25.2,25.8,28.9,30.2,28.2,19.9,11.6,7.6,19.6},
  {7.5,15.3,16.5,17.6,25.5,29.5,31.0,31.1,23.6,16.7,9.7,6.9,19.2},
  {7.3,8.1,15.9,20.2,25.0,27.2,30.2,27.6,23.5,16.6,9.2,4.1,17.9},
  {5.9,10.2,14.1,17.0,23.9,28.0,26.2,27.8,23.1,14.6,7.5,6.0,17.0},
  {4.2,11.1,15.2,18.0,27.2,27.3,28.7,30.2,20.4,21.4,12.0,7.0,18.6},
  {7.6,11.6,17.4,19.1,23.0,29.5,30.0,28.4,23.3,18.6,12.2,7.7,19.0},
  {7.7,9.1,18.4,19.2,26.3,32.3,31.1,33.9,25.3,15.8,11.6,7.9,19.9},
  {6.5,10.5,14.5,19.5,22.2,28.2,28.5,28.2,25.2,18.0,12.0,7.5,18.4},
  {7.5,8.5,15.9,18.9,24.0,29.5,30.1,28.4,25.3,19.1,11.3,4.4,18.6},
  {6.0,8.0,13.0,20.0,23.9,29.8,32.9,25.8,26.4,19.9,12.7,7.6,18.8},
  {9.4,12.2,16.1,25.2,25.9,28.8,31.4,28.3,23.5,18.4,10.4,7.5,19.8},
  {7.6,12.6,14.4,17.2,25.4,28.5,29.5,29.9,23.3,19.0,10.3,5.9,18.6},
  {6.1,9.0,14.5,20.8,27.6,28.8,31.2,32.1,25.5,18.5,11.3,4.8,19.2},
  {4.5,8.2,14.3,20.8,21.3,27.9,32.8,27.9,23.0,16.1,9.8,3.6,17.5},
  {5.2,10.4,14.9,22.5,25.5,25.1,26.8,29.4,25.7,17.5,11.4,6.4,18.4},
  {6.8,8.6,19.0,17.0,23.7,27.7,29.0,30.0,23.2,17.5,11.0,5.4,18.2},
  {7.4,7.8,11.5,18.5,20.6,26.6,30.9,29.7,24.3,17.2,10.9,8.2,17.8},
  {6.6,9.2,17.7,20.0,22.4,28.0,26.8,24.7,24.0,19.1,12.6,8.2,18.3},
  {7.7,10.1,14.8,19.9,23.5,27.7,32.5,29.4,22.5,16.9,13.4,7.9,18.9},
  {6.6,10.0,14.8,19.3,21.5,26.0,28.7,27.9,26.1,16.6,10.3,9.0,18.1},
  {5.4,10.5,17.9,19.4,24.5,29.2,29.2,29.1,20.5,19.1,10.5,5.0,18.4}
};
            int arrayH = temp.GetLength(0);
            int arrayW = temp.GetLength(1);
            int year = 1983;
            double monthlyAverage = 0;
            for (int i = 0; i < arrayH; i++)
            {
                monthlyAverage = 0;
                for (int j = 0; j < (arrayW - 1); j++)
                {
                    monthlyAverage = monthlyAverage + temp[i, j];
                }
                monthlyAverage = monthlyAverage / (arrayW - 1);
                Console.WriteLine("Jahr: {0}, Durchschnitt ich: {1}, Durchscnitt Provinz: {2}, Differenz: {3}", year, monthlyAverage, temp[i, 12], (temp[i, 12]-monthlyAverage));
                year++;
            }
            int month = 1;
            double yearlyAverage = 0;
            for (int i = 0; i < (arrayW - 1); i++)
            {
                yearlyAverage = 0;
                for (int j = 0; j < arrayH; j++)
                {
                    yearlyAverage = yearlyAverage + temp[j, i];
                }
                yearlyAverage = yearlyAverage / arrayH;
                Console.WriteLine("Monat: {0}, Durchschnitt: {1}", month, yearlyAverage);
                month++;
            }
            double[] yearlyArray = new double[arrayW];
            for (int i = 0; i < (arrayW - 1); i++)
            {
                yearlyAverage = 0;
                for (int j = 0; j < arrayH; j++)
                {
                    yearlyAverage = yearlyAverage + temp[j, i];
                }
                yearlyAverage = yearlyAverage / arrayH;
                yearlyArray[i] = yearlyAverage;
            }
            double triAverage = 0;
            int trimester = 1;
            for (int i = 0; i < (arrayW - 1); i = i+3)
            {
                triAverage = (yearlyArray[i] + yearlyArray[i + 1] + yearlyArray[i + 2]) / 3;
                Console.WriteLine("Trimester {0}: {1}", trimester, triAverage);
                trimester++;
            }
            double decade = 0;
            for (int i = 0; i < 7; i++)
            {
                decade = decade + temp[i, 12];
            }
            decade = decade / 7;
            Console.WriteLine("Dekade 1: " + decade);
            int decadeNr = 2;
            for (int i = 7; i < (arrayH - 8); i= i + 10)
            {
                decade = 0;
                for (int j = 0; j < 10; j++)
                {
                    decade = decade + temp[i, 12];
                }
                decade = decade / 10.0;
                Console.WriteLine("Dekade {0}: {1}", decadeNr, decade);
                decadeNr++;
            }
            decade = 0;
            for (int i = 27; i < 35; i++)
            {
                decade = decade + temp[i, 12];
            }
            decade = decade / 8;
            Console.WriteLine("Dekade 4: " + decade);
            Console.ReadKey();
        }
    }
}
