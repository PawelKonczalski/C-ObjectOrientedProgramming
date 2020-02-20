using System;

class Program
{
    static void Main(string[] args)
    {
        string a = "Any sentence for method testing";
        // Console.WriteLine(StringHelper.IsCapitalized(a));
        Console.WriteLine(a.IsCapitalized());
        
       Test b = new Test();
       b.tester();
    }
}

static class StringHelper
{
    // public static bool IsCapitalized(string value)
    // {
    //     return Char.IsUpper(value[0]);
    // }
    public static bool IsCapitalized(this string value)
    {
        return Char.IsUpper(value[0]);
    }
}

class Test
{
}

class Test2 : Test
{
}

static class TestHelper
{
    public static bool tester(this Test value)
    {
        return true;
    }
}