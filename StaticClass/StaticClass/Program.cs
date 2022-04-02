using System;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is:" + MyMath.PI);
            Console.WriteLine("Value of cube is:" + MyMath.cube(3));   

        }
    }
    public static class MyMath
    {
        public static float PI = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
}
