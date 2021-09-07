using System;
namespace GeomObjects
{
    public class Circle
    {
        public double Radius { get; set; }

        private int xpos = 0;
        private int ypos = 0;

        public Circle()
        {
        }

        public double area()
        {
            return this.Radius * Math.PI;
        }

        public double circ()
        {
            return this.Radius * 2 * Math.PI;
        }

        public override String ToString()
        {
            return "Circle: r=" + this.Radius;
        }
    }
}
