using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T tmp;

        tmp = a;
        a = b;
        b = tmp;
    }
    
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        string c = "lala";
        string d = "haha";
        
        Swap(ref a, ref b);
        Swap(ref c, ref d);

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
        Console.ReadLine();
    }
}