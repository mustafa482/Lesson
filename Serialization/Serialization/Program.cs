using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization1
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("d:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = new Student(101, "sonoo");

            formatter.Serialize(fileStream, s);
            fileStream.Close();
        }
    }
    [Serializable]
    public class Student
    {
        int rollno;
        string name;
        public Student(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

    }
}
