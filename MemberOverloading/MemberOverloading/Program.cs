using System;

namespace MemberOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cal.add(10,20,21));
        }
    }
    public class Cal
    {
        public static int add(int a,int b)
        {
            return a + b;
        }
        public static float add(int a,int b,int c)
        {
            return (a + b) + c;
        }
    }
}
