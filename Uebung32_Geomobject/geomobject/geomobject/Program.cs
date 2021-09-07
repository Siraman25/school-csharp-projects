using System;

namespace GeomObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            String key = "l";
            Rectangle r = new Rectangle(10, 10, 5, 10);
            Rectangle r2 = new Rectangle();

            while (key == "l" || key == "r" || key == "u" || key == "d")
            {
                if (key == "l")
                {
                    r.moveleft(1);
                }
                Console.Clear();
                r.drawConsole();
                Console.Write("Command: ");
                key = Console.ReadLine();
            }

        }
    }
}
