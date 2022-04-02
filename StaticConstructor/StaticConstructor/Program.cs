using System;

namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100, "Mustafa");
            Account account1 = new Account(101, "ILkin");

            account.display();
            account1.display();

        }
    }
    public class Account
    {
        public int id;
        public string name;
        public static float rateOfInterest;
        public Account(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            rateOfInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }
}
