using System;

namespace MultidimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr1 = new int[3, 3];
            //int[,,] arr2 = new int[3, 3, 3];

            //arr1[0, 1] = 10;
            //arr1[1, 2] = 20;
            //arr1[2, 0] = 30;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(arr1[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
