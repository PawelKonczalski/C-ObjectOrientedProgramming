using System;

class Program
{
    static void Main(string[] args)
    {
        new Test<className>();

        StaticTest<int>.x++;
        StaticTest<Test<A>>.x++;
        Console.WriteLine(StaticTest<int>.x);
        Console.ReadLine();
    }
}

/*
 * CONSTRAINT
 * where T : class - T must be class
 * where T : structure - T must be structure 
 * where T : INameOfInterface - T must be interface or implement interface
 * where T : className - T must be className type or inheritance className
 * where T : new() - T must have no parameter constructor
 */
class Test<T> where T : new()
{
    public T mz { get; set; }

    public Test()
    {
        this.mz = default(T);
    }
}

class A
{
}

struct B
{
}

interface IC
{
}

class className
{
}

abstract class Calculatro<T> where T : struct
{
    public abstract T add(T x, T y);
    public abstract T odd(T x, T y);
}

class IntCalculator : Calculatro<int>
{
    public override int add(int x, int y)
    {
        return x + y;
    }

    public override int odd(int x, int y)
    {
        return x - y;
    }
}

class DoubleCalculator<U> : Calculatro<double>
{
    private U zmTypeU;

    public override double add(double x, double y)
    {
        return x + y;
    }

    public override double odd(double x, double y)
    {
        return x - y;
    }
}

class StaticTest<T>
{
    public static int x;
}