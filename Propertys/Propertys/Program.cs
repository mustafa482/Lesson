using System;

namespace Propertys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Bastian Shelwell";
            Console.WriteLine("Employee Name: {0}",employee.Name);
        }
    }
    public class Employee
    {
        private string name;
        public string Name { get { return name; }set { name = value; } }
    }
}
