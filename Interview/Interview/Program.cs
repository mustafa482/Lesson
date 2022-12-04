
delegate void Test();

class MyClass
{
    static event Test x
    {
        add
        {
            Console.WriteLine("Added");
        }
        remove
        {
            Console.WriteLine("Removed");
        }
    }
    static void Main()
    {
        x += Sinaq;
        x -= Sinaq;

    }

    private static void Asadsda()
    {
        Console.WriteLine("salam");
    }

    private static void MyClass_x()
    {
        Console.WriteLine("Hola");
    }

    static void Sinaq()
    {
        Console.WriteLine("Hello");
    }
}
