using System;

namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Personal personal = new Personal();
            personal.Name = "Mustafa";
            personal.Id = 19;
            personal.Email = "mustafa5566";
            Console.WriteLine("Id: " + personal.Id);
            Console.WriteLine("Name: " + personal.Name);
            Console.WriteLine("Email: " + personal.Email);


        }
    }
}
