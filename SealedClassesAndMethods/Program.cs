using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}

class EndClass
{
    public virtual void test()
    {
        
    }
}

class DerivativeClass : EndClass
{
    public sealed override void test()
    {
        base.test();
    }
}