using System;

namespace ArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //isFixedSize --Massivin sabit ölçüsü olub-olmadığını göstərən dəyər əldə etmək üçün istifadə olunur.
            //isReadOnly --Massivin yalnız oxunaqlı olub-olmadığını yoxlamaq üçün istifadə olunur.
            //IsSynchronized --Array-a girişin sinxronlaşdırılıb-sinxronlaşdırılmadığını yoxlamaq üçün istifadə olunur.
            //Length -- Massivin bütün ölçülərində elementlərin ümumi sayını almaq üçün istifadə olunur.
            //LongLength --Massivin bütün ölçülərində elementlərin ümumi sayını əks etdirən 64 bitlik tam ədədi almaq üçün istifadə olunur.
            //Rank --Massivin dərəcəsini (ölçülərinin sayını) almaq üçün istifadə olunur.
            //SyncRoot --Array-a girişi sinxronlaşdırmaq üçün istifadə edilə bilən bir obyekt əldə etmək üçün istifadə olunur.

            int[] arr = new int[6] { 20, 23, 2, 11, 0, 7 };
            int[] arr2 = new int[6];

            Console.WriteLine("length of first array:" + arr.Length);

            Array.Sort(arr);
            Console.WriteLine("First Array elements");
            PrintArray(arr);
            Console.WriteLine("\nIndex position of 11 is" + " " + Array.IndexOf(arr,11));
            Array.Copy(arr,arr2,arr.Length);
            PrintArray(arr2);
            Array.Reverse(arr);
            PrintArray(arr);

        }
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item +" ");
            }
        }
    }
}
