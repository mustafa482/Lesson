using System;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(20,10);
            r.areaOfRectangle();

            //r.height = 10;
            //r.width = 5;
            //Console.WriteLine("Area of Rectangle is: " + r.height * r.width);
        }
    }
    public struct Rectangle
    {
        public int width, height;

        public Rectangle(int h,int w)
        {
            width = w;
            height = h;
        }
        public void areaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }

    }
    
}
