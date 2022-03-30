using System;

namespace OutParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("Value before passing out variable " +val);
            program.Show(out val);
            Console.WriteLine("Value after passing out variable " + val);

        }
        public void Show(out int val)
        {
            int square = 5;
            val = square;
            val *= val;
        }
        //out = öz metodunun yeni Shov metodunun içindəki dəyərləri alır.Ref ise Main metodunun icindeki.Tebii ki eyni ad olmalidi.yeni val.
    }
}
