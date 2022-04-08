using System;
using System.Collections.Generic; 

namespace Collections_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<int> name = new List<int>();
            var names = new List<string> { "Mustafa","Ilkin","Ferid","Urfan"};
            //names.Add("Sonoo Jaival");
            //names.Add("Anket");
            //names.Add("Buket");
            //names.Add("Hanry");

            foreach (var coll in names)
            {
                Console.WriteLine(coll);
            }

        }
    }
}
