using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employeed employeed = new Employeed(101,"Mustafa",90999f);
            Employeed employeed1 = new Employeed(102,"Ilkin",98928f);

            employeed.display();
            employeed1.display();
        }
        public class Employeed
        {
            public int id { get; set; }
            public string Name { get; set; }
            public float Salary { get; set; }

            public Employeed(int i,string n,float s)
            {
                id = i;
                Name = n;
                Salary = s;
            }
            public void display()
            {
                Console.WriteLine(id + " " + Name + " " + Salary);
            }
        }
    }
}
