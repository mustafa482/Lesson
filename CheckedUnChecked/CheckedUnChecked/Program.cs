using System;

namespace CheckedUnChecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked//Checked icinde yazanda xetani gore bilirik.Ama unchecked yazanda veya hecne yazmiyanda xeta gormur ve hesablayir.
            {
                int val = int.MaxValue;
                Console.WriteLine(val +2);
            }
        }
    }
}
