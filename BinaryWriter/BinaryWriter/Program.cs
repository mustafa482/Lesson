using System;
using System.IO;

namespace BinaryWriterExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fileName = "d:\\binaryfile.dat";
            using (BinaryWriter bw = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                bw.Write(2.5);
                bw.Write("this is string data");
                bw.Write(true);
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
