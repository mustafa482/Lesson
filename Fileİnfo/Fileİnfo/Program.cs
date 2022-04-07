using System;
using System.IO;

namespace Fileİnfo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "d:\\abc.txt";
                FileInfo fileInfo = new FileInfo(loc);

                //StreamWriter sw = fileInfo.CreateText();
                //sw.WriteLine("This text is written to the file by using StreamWriter class");
                //sw.Close();

                StreamReader sr = fileInfo.OpenText();
                string data = "";
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }

                //fileInfo.Create();
                //Console.WriteLine("File is created Successfuly");
            }
            catch (IOException e)
            {

                Console.WriteLine("Something went wrong: " + e);
            }
        }
    }
}
