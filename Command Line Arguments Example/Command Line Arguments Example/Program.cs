using System;

namespace Command_Line_Arguments_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argument length" + " " + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
