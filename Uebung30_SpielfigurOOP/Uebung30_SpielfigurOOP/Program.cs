using System;
using System.Text;
using Microsoft.VisualBasic;

namespace Uebung30_SpielfigurOOP
{
    class Spielfigur
    {
        private int pos_x;
        private int pos_y;

        public void setPosition(int x, int y)
        {
            if (x < 80)
            {
                if (y < 26)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("X");
                }
                else
                {
                    throw new Exception("Y cannot be more than 24. Aborting...");
                }
            }
            else
            {
                throw new Exception("X cannot be more than 79. Aborting...");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string string_position = "";
            while (true)
            {
                Console.Clear();
                Console.Write("Select position (0,0=top,left), write in format 0,0 (csv), write QUIT if you want to exit: ");
                string_position = Console.ReadLine();
                if (string_position == "QUIT")
                {
                    Environment.Exit(0);
                }
                Console.Clear();
                string[] string_coll = string_position.Split(",");
                int pos_x = Convert.ToInt32(string_coll[1]);
                int pos_y = Convert.ToInt32(string_coll[0]) + 1;

                Spielfigur Figur = new Spielfigur();
                Figur.setPosition(pos_x, pos_y);
                
                Console.SetCursorPosition(0, 0);
                Console.Write("Thank you! Press a key to continue.");
                Console.ReadKey();
            }
        }
    }
}