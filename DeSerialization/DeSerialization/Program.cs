using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeSerialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("d:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s =(Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }
    }
    
    [Serializable]
    public class Student
    {
       public int rollno;
       public string name;
        public Student(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

    }
}
