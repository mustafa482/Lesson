using System;
using System.IO;
using System.Text;

namespace StringWriterr
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, Welcome to the javatpoint \n" +
               "It is nice site. \n" +
               "It provides technical tutorials";
            StringBuilder stringBuilder = new StringBuilder();
            StringWriter sw = new StringWriter(stringBuilder);

            sw.WriteLine(text);
            sw.Flush();

            sw.Close();


            StringReader stringReader = new StringReader(stringBuilder.ToString());


        }
    }
}
