using System;

namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                TestUserDefinedException.validate(age);
            }
            catch (InvalidAgeException e)
            {

                Console.WriteLine(e);
            }
            Console.WriteLine("Rest of the code");
        }
    }
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message):base(message)
        {

        }
    }
    public class TestUserDefinedException
    {
       public static void validate(int age)
        {
            if (age<18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }

    }
}
