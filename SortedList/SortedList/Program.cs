using System;
using System.Collections.Generic;

namespace SortedList1
{
    public class Program
    {
        static void Main(string[] args)
        {

            SortedSet<string> names = new SortedSet<string>();//SortedSet bas herflerine gore elifbaya gore siralayir.
            names.Add("Mustafa");
            names.Add("Ilkin");
            names.Add("Urfan");
            names.Add("Uzeyir");
            names.Add("Uzeyir");//Eyni adda daxil edilen bir defe yaradilir.Bu daxil edilmir.Tekrar oldugu ucun.



            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
