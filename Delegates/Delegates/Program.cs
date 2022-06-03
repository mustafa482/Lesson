using System;

namespace Delegates
{
    public class Program
    {
       public delegate int Calculator(int n);
        static void Main(string[] args)
        {
            Calculator c1 = DelegateExample.add;
            Calculator c2 = DelegateExample.mul;
            c1(20);
            Console.WriteLine("After c1 delegate, Number is: " + DelegateExample.getNumber());
            c2(3);
            Console.WriteLine("After c2 delegate, Number is: " + DelegateExample.getNumber());


        }
    }
    public class DelegateExample
    {
        static int number = 100;
        public static int add(int n)
        {
            number = number + n;
            return number;
        }
        public static int mul(int n)
        {
            number = number * n;
            return number;
        }
        public static int getNumber()
        {
            return number;
        }
    }
}
