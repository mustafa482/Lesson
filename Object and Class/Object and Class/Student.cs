using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_Class
{
    public  class Student
    {
        public int id { get; set; }
        public string name { get; set; }

        public float Salary { get; set; }
        public void insert(int i,string n,float s)
        {
            id = i;
            name = n;
            Salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + Salary);
        }
    }
    
}
