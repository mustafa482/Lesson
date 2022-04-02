using System;

namespace Object_and_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Student student1 = new Student();

            student.insert(100, "Mustafa",10000);
            student1.insert(101, "Ilkin",9000);

            student.display();
            student1.display();


        }
    }
   
}
