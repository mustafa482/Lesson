using System;
using System.Collections.Generic;

namespace Collections_HashSet
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Mustafa");
            names.Add("Ilkin");
            names.Add("Urfan");
            names.Add("Uzeyir");
            names.Add("Elsever");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
