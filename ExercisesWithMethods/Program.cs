using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Mathematic.Abs(-5));

        int nr = 10;
        Mathematic.IncreaseBy5(ref nr);
        Console.WriteLine(nr);
        Console.WriteLine(Mathematic.IncreaseBy5(20));
        
        int b;
        Mathematic.ResetNumber(out b);
        Console.WriteLine(b);

        Console.WriteLine(Mathematic.Add(2,3,5,9));

        Console.WriteLine(Mathematic.Intensifies(2,3));
        
        Citizen citizen = new Citizen("Max", "Klos");
        Console.WriteLine(citizen.firstName + " " + citizen.lastName);
    }
}

class Mathematic
{
    public static int Abs(int number)
    {
        if (number < 0)
        {
            return number * -1;
        }
        else
        {
            return number;
        }
    }
    public static int IncreaseBy5(int x)
    {
        return x + 5;
    } 
    public static int IncreaseBy5(ref int x)
    {
        x += 5;
        return x;
    }

    public static void ResetNumber(out int n)
    {
        n = 0;
    }
    public static int Add(params int[] args)
    {
        int result = 0;
        foreach (int arg in args)
        {
            result += arg;
        }
        return result;
    }
    public static int Intensifies(int a, int b)
    {
        int temp = a;
        for (int i = 1; i < b; i++)
        {
            a *= temp;
        }
        return a;
    }
}

class Citizen
{
    public string firstName { get; }
    public string lastName { get; }

    public Citizen(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    
}