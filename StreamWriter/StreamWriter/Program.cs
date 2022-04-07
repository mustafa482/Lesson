using System;
using System.IO;

namespace StreamWriterr
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("d:\\output.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(f);

            sw.WriteLine("Hello c#");

            sw.Close();
            f.Close();
           
        }
    }
}
