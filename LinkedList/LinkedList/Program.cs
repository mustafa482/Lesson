using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            /*names.AddFirst("John");*///AddFirst oldugu ucun 1ci olacaq.

            LinkedListNode<string> node = names.Find("Peter");//LinkedListNode burda verdiyimiz ve yuxarida olan addan evvel yada sonra olmasini istediyimiz deger veririk.
            names.AddAfter(node, "Lice");
            names.AddBefore(node, "Jonh");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
