using System;

namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ineligible:
            Console.WriteLine("You are not eligible to vote!");

            Console.WriteLine("Enter your age:\n");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num<18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible vote!");
            }


        }
    }
}
