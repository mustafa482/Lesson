using System;

namespace Base
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.showColor();
        }
    }
    public class Animal
    {
        public string color = "White";
    }
    public class Dog : Animal
    {
        string color = "black";
        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }
}
