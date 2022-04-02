using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.setHeight(10);
            rec.setWidth(5);

            Console.WriteLine("Total Area: {0}", rec.getArea());
            Console.ReadLine();
        }

    }
    public class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h; 
        }



        protected int width;
        protected int height;
    }
    public class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
}
