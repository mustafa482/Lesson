using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[2] = 30;
            //arr[4] = 50;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            int[] arr1  = new int[5]{1,2,3,4,5};//1
            int[] arr2 = new int[]{ 1, 2, 3, 4, 5 };//2
            int[] arr3 = { 10, 20, 30, 40, 50 };//3

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}

            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }



        }
    }
}
