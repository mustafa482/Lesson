using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Show(1, 2, 3, 4, 5, 6, 7);
            program.Show("ABdul", 120, "AMD", 12);
        }
        //public void Show(params int[] val)
        //{


        //    for (int i = 0; i < val.Length; i++)
        //    {
        //        Console.WriteLine(val[i]);
        //    }
        //}

        public void Show(params object[] item)
        {


            for (int i = 0; i < item.Length; i++)
            {
                Console.WriteLine(item[i]);
            }
        }
    }
}
