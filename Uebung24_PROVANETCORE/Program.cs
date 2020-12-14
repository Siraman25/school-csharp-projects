using System;

namespace Uebung24_PROVANETCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeater = true;
            while (repeater)
            {
                int selector = 5;
                string repeaterText = "";
                while (selector < 1 || selector > 3)
                {
                    System.Console.WriteLine("Select from 1-3");
                    selector = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("You selected {0}.", selector);
                }
                switch (selector)
                {
                    case 1:
                        System.Console.WriteLine("1");
                        break;
                    case 2:
                        System.Console.WriteLine("2");
                        break;
                    case 3:
                        System.Console.WriteLine("3");
                        break;
                    default:
                        System.Console.WriteLine("ERROR");
                        break;
                }
                System.Console.WriteLine("END!");
                System.Console.Write("Writing changes");
                for (int i = 0; i < 100; i++)
                {
                    System.Console.Write(".");
                    
                }
                Console.WriteLine();

                System.Console.WriteLine("Do you want to repeat your program? (YES/NO)");
                repeaterText = Console.ReadLine();
                if (repeaterText == "YES")
                {
                    System.Console.WriteLine("The program will repeat.");
                    repeater = true;
                }
                else if (repeaterText == "NO")
                {
                    System.Console.WriteLine("The program will terminate.");
                    repeater = false;
                }
                else
                {
                    System.Console.WriteLine("Wrong input, the program will terminate.");
                    repeater = false;
                }
            }
            
        }
    }
}
