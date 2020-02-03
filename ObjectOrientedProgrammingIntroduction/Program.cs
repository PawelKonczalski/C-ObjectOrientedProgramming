using System;

class Program
{
    private static void Main(string[] args)
    {
        Person a = new Person();
        Console.WriteLine(a.getName());

        a.setName("My name is Alex");
        Console.WriteLine(a.getName());
    }
}

class Person
{
    private static string name = "My name is Max";
    public string getName()
    {
        return name;
    }
    public void setName(string newName)
    {
        name = newName;
    }
}