﻿
using System;

namespace CallByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("Value before calling the function " + val);
            program.Show(10);
            Console.WriteLine("Value after calling the function " + val);
        }
        public void Show(int val)
        {
            val *= val;
            Console.WriteLine("Value inside the show function " + val);
        }
    }
}
