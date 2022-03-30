using System;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
             string message = program.Show("Ilkin");
            Console.WriteLine("Hello " + message );

        }
        public string Show(string message)
        {
            Console.WriteLine("Inside Show Function");
            return message;
            
        }
    }
}
