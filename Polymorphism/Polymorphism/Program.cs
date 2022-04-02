using System;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.eat();
            Console.WriteLine(a.color);
        }
    }
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating");
        }
        public string color = "ag";
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread");
        }
        public string color = "qara";
    }
}
