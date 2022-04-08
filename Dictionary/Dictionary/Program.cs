using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Peter");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");
            foreach (KeyValuePair<string,string> dc in names)
            {
                Console.WriteLine(dc.Key + " " + dc.Value);
            }
        }
    }
}
