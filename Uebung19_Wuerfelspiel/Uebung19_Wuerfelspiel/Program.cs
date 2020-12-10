using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung17_Wuerfelspiel
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAYDIMENSION = 5000;
            int[] RandomArray = new int[ARRAYDIMENSION];
            Random Randomic = new Random();
            for (int i = 0; i < ARRAYDIMENSION; i++)
            {
                RandomArray[i] = Randomic.Next(1, 7);
            }

            int NumberOne = 0, NumberTwo = 0, NumberThree = 0, NumberFour = 0, NumberFive = 0, NumberSix = 0;
            for (int j = 0; j < ARRAYDIMENSION; j++)
            {
                int CurrentNumber = RandomArray[j];
                switch (CurrentNumber)
                {
                    case 1:
                        NumberOne += 1;
                        break;
                    case 2:
                        NumberTwo += 1;
                        break;
                    case 3:
                        NumberThree += 1;
                        break;
                    case 4:
                        NumberFour += 1;
                        break;
                    case 5:
                        NumberFive += 1;
                        break;
                    case 6:
                        NumberSix += 1;
                        break;
                    default:
                        Console.WriteLine("ERROR!");
                        break;
                }
            }
            double NumberOneDecimal, NumberTwoDecimal, NumberThreeDecimal, NumberFourDecimal, NumberFiveDecimal, NumberSixDecimal;
            NumberOneDecimal = (double)NumberOne / ARRAYDIMENSION;
            NumberTwoDecimal = (double)NumberTwo / ARRAYDIMENSION;
            NumberThreeDecimal = (double)NumberThree / ARRAYDIMENSION;
            NumberFourDecimal = (double)NumberFour / ARRAYDIMENSION;
            NumberFiveDecimal = (double)NumberFive / ARRAYDIMENSION;
            NumberSixDecimal = (double)NumberSix / ARRAYDIMENSION;

            Console.WriteLine("Nach " + ARRAYDIMENSION + " würfeln erhalten wir folgende Ergebnisse:");
            Console.WriteLine("1er: {0} entspricht {1}%.", NumberOne, NumberOneDecimal * 100);
            Console.WriteLine("2er: {0} entspricht {1}%.", NumberTwo, NumberTwoDecimal * 100);
            Console.WriteLine("3er: {0} entspricht {1}%.", NumberThree, NumberThreeDecimal * 100);
            Console.WriteLine("4er: {0} entspricht {1}%.", NumberFour, NumberFourDecimal * 100);
            Console.WriteLine("5er: {0} entspricht {1}%.", NumberFive, NumberFiveDecimal * 100);
            Console.WriteLine("6er: {0} entspricht {1}%.", NumberSix, NumberSixDecimal * 100);
            Console.ReadKey();
        }
    }
}
