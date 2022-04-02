using System;

namespace Aggregation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adress a1 = new Adress("Xetayi", "Telnov", "Baku");
            Employee e1 = new Employee(1, "Mustafa", a1);
            e1.display();
            Console.ReadLine();
        }
    }
    public class Adress
    {
        public string adressline, state, city;
        public Adress(string adressline,string state,string city)
        {
            this.adressline = adressline;
            this.state = state; 
            this.city = city;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Adress adress;
        public Employee(int id,string name,Adress adress)
        {
            this.name = name;
            this.id = id;
            this.adress = adress;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + adress.adressline + " " + adress.state + " " + adress.city);
        }

    }
}
