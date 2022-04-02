using System;

namespace MethodOverriding
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.eat();
        }
    }
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread");
        }
    }
}
