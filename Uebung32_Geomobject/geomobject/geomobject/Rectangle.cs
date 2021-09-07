using System;
namespace GeomObjects
{
    public class Rectangle
    {
        private int xpos;
        private int ypos;
        private int width;
        private int height;

        public Rectangle()
        {
            this.xpos = 0;
            this.ypos = 0;
            this.width = 0;
            this.height = 0;
        }

        public Rectangle(int xpos, int ypos, int width, int height)
        {
            this.xpos = xpos;
            this.ypos = ypos;
            this.width = width;
            this.height = height;
        }

        public void moveleft(int val)
        {
            if ((this.xpos - val) < 0)
            {
                throw new Exception("Error xpos negative");
            }
            else
            {
                this.xpos -= val;
            }
        }

        public void setXpos(int xpos)
        {
            if (xpos > 80)
            {
                throw new Exception("Error, value too large");
            }
            else
            {
                this.xpos = xpos;
            }
        }

        public double area()
        {
            return this.width * this.height;
        }

        public double perimeter()
        {
            return 2 * (width + height);
        }

        public void drawConsole()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int j = ypos; j < (ypos+height); j++)
            {
                for (int i = xpos; i < (xpos+width); i++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write("*");
                }
            }
        }

        public override String ToString()
        {
            return "Rect: [" + xpos+","+ypos+"," +width+ "," +height+"]";
        }
    }
}
