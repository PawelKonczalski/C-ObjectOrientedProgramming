using System;

class Program
{
    public static int? getSomethingFromDataBase()
    {
        return null;
    }

    static void Main(string[] args)
    {
        int? a = getSomethingFromDataBase();

        Console.WriteLine(a);

        if (a == null)
        {
            Console.WriteLine("you didn't enter a value");
        }
        else
        {
            Console.WriteLine(a);
        }

        int b = a ?? 0;
        Console.WriteLine(b);
    }
}