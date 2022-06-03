using System;
using System.Collections.Generic;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            GeneriClass<string> gen = new GeneriClass<string>("This is generic class");
            GeneriClass<int> genI = new GeneriClass<int>(101);
            GeneriClass<char> gencCh = new GeneriClass<char>('G');

            Generic generic = new Generic();
            generic.Show("This is generic method");
            generic.Show(100);
            generic.Show('B');
        }
    }
    public class GeneriClass<T>
    {
        public GeneriClass( T msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class Generic
    {
        public void Show<B>(B message)
        {
            Console.WriteLine(message);
        }
    }
}
