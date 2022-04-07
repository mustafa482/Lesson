using System;
using System.IO;


namespace Filestream
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FileStream f = new FileStream("d://a.txt", FileMode.OpenOrCreate);
            //f.WriteByte(65);
            //f.Close();

            FileStream fileStream = new FileStream("d:\\elifba.txt", FileMode.OpenOrCreate);
            //for (int i = 65; i <= 90; i++)
            //{
            //    fileStream.WriteByte((byte)i);

            //}
            int i = 0;
            while ((i = fileStream.ReadByte())!=-1)
            {
                Console.Write((char)i);
            }
            fileStream.Close();
        }
    }
}
