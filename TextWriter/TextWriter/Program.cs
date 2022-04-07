using System;
using System.IO;

namespace TextWriterExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(TextWriter writer = File.CreateText("d:\\Text.txt"))
            {
                writer.WriteLine("Hello c#");
                writer.WriteLine("C# File Handling by JavaTpoint");
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
