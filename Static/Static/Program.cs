using System;

namespace Static
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account.rateOfinterest = 8f;    
            Account account = new Account(10, "Mustafa");
            Account account1 = new Account(11, "Ilkin");
            Account account2 = new Account(12, "Urfan");


            account.display();
            account1.display();
            account2.display();
            Console.WriteLine("Total objects are:" + Account.count);

        }
    }
    public class Account
    {
        public string Name { get; set; }
        public int accno { get; set; }
        public static float rateOfinterest = 12f;
        public static int count = 0;
        public Account(int accno,string Name)
        {
            this.accno = accno;
            this.Name = Name;
            count++;
        }

        public void display()
        {
            //Console.WriteLine(accno + " " + Name + " " + rateOfinterest);
            Console.WriteLine(accno + " " + Name);
        }
    }
}
