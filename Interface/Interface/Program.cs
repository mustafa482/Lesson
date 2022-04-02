using System;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            //abstract classdaki abstract metodu basqa clasda eyni adla isledmek ucun bu clasdan inherit edib orda override etmek lazimdi.
            //interface icindeki metodu basqa classda eyni adla istifade etmek ucun sadece inherit edirsen.Override ehtiyac qalmir.
            Drawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();

        }
    }
    public interface Drawable
    {
        void draw();
    }
    public class Rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class Circle: Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawable circle");
        }
    }
}
