
using System;

namespace Abstract
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
        }
    }
    public abstract class Shape
    {
        public abstract void draw();//abstract özünü virtual kimi aparır.Method abstractdirsa class da abstract olmalidi.
    }
    public class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle");       
        }
    }
    public class Circle: Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
}
