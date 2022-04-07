using System;
using System.IO;

namespace TextReaderExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(TextReader textReader = File.OpenText("d:\\Text.txt"))
            {
                Console.WriteLine(textReader.ReadToEnd());
            }
        }
    }
}
