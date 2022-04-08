using System;
using System.Collections.Generic;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();//Stack yazdigimizin tersine siralayir.
            names.Push("Mustafa");
            names.Push("Ilkin");
            names.Push("Ferid");
            names.Push("Eli");
            names.Push("Urfan");
            

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
        }
    }
}
