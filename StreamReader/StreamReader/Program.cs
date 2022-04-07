using System;
using System.IO;

namespace StreamReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("d:\\output.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(fileStream);

            string line= s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            fileStream.Close();

            

        }
    }
}
