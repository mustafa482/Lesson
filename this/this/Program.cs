using System;

namespace This
{
    public class Program
    {
    static void Main(string[] args)
    {
            Employee employee = new Employee(100, "Mustafa", 291829f);
            Employee employee1 = new Employee(101, "Ilkin", 211829f);

            employee.display();
            employee1.display();

        }

    }
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public float salary { get; set; }

        public Employee(int id,string name,float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;


        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }

    
}

