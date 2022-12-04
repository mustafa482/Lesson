int a = 0, b = 1, c, n;

Console.Write("Enter the number: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <=n; i++)
{
    a = 0;
    b = 1;
    Console.Write(b+"\t");

    for (int j = 1; j < i; j++)
    {
        c = a + b;
        Console.Write(c + "\t");
        a = b;
        b = c;
    }
    Console.Write("\n");
}
