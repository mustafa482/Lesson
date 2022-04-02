using System;

namespace Sealed
{
    public class Program
    {
        static void Main(string[] args)
        {
            //sealed bloklamaq demekdir.Ona gore de basqa class onu inherit ede bilmir.Methodada tetbiq etmek olur.Meselen bir methodu sealed ediremse onu inherit edilmis clasda override etmek olmur.
            
            
        }
    }
   public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating");
        }
        public virtual void run()
        {
            Console.WriteLine("Running");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread");
        }
        public sealed override void run()
        {
            Console.WriteLine("Running very fast");
        }
    }
    public class BabyDog : Dog
    {
        public override void eat()
        {
            Console.WriteLine("Eating biscuits");
        }
        
    }
    
}
