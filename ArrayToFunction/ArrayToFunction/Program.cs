using System;

namespace ArrayToFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 25, 10, 30, 20 };
            int[] arr2 = { 40, 50, 65, 74 };

            printMin(arr1);
            printMin(arr2);



            //printArray(arr1);
            //printArray(arr2);



        }
       static void printArray(int[] arr)
        {
            Console.WriteLine("Printing array elements:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void printMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                
            }
            Console.WriteLine("Min element is "+ min);
        }
    }
}
