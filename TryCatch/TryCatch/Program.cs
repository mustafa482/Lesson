﻿using System;

namespace TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            Console.WriteLine("Rest of the code");
        }
    }
}
