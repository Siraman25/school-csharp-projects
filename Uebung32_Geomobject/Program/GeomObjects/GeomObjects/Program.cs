using System;

namespace GeomObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            String key = "l";
            Rectangle r = new Rectangle(10, 10, 5, 5);
            Rectangle r2 = new Rectangle(10, 16, 5, 5);

            while (key == "l" || key == "r" || key == "u" || key == "d")
            {
                if (key == "l")
                {
                    r.moveleft(1);
                    r2.moveleft(1);
                }
                if (key == "r")
                {
                    r.moveright(1);
                    r2.moveright(1);
                }
                if (key == "u")
                {
                    r.moveup(1);
                    r2.moveup(1);
                }
                if (key == "d")
                {
                    r.movedown(1);
                    r2.movedown(1);
                }
                Console.Clear();
                r.drawConsole();
                r2.drawConsole();
                Console.Write("Command: ");
                key = Console.ReadLine();
            }

        }
    }
}