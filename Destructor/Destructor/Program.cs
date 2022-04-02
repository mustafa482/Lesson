using System;

namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
                new Employeed(i);
            Console.WriteLine("************");

            GC.Collect();
            Console.Read();
        }
    }
   public class Employeed
    {
        public int ID { get; set; }
        public Employeed(int i)
        {
            ID = i;
            Console.WriteLine(ID +  " yarandi");
        }
        ~Employeed()
        {
            Console.WriteLine(ID + " silindi");
        }

    }
}
