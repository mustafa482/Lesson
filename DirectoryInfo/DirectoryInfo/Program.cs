using System;
using System.IO;

namespace DirectoryInfo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(@"d:\javatpoint");


                directoryInfo.Delete();
                Console.WriteLine("The directory is deleted successfully.");

                //if (directoryInfo.Exists)//Kataloqun olub olmamasi yoxlanilir.
                //{
                //    Console.WriteLine("Directory already exist");
                //    return;
                //}
                //directoryInfo.Create();
                //Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {

                Console.WriteLine("Directory not created: {0}", e.ToString());
            }

        }
    }
}
