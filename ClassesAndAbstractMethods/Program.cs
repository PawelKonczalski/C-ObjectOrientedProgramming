using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Worker("Rox", "Mox", 2000);
        Person[] persons = new Person[4];
        persons[0] = new Worker("All", "Bors", 25000);
        persons[1] = new Student("John", "Wilson", 1);

        // for (int i = 0; i < persons.Length; i++)
        // {
        //     if (persons[i] != null)
        //     {
        //         Console.WriteLine(persons[i].Description());
        //     }
        // }
        
        Person.writeElement(persons);

        Console.WriteLine(person.Description());
    }
}

abstract class Person
{
    public static void writeElement(Person[] persons)
    {
        for (int i = 0; i < persons.Length; i++)
        {
            if (persons[i] != null)
            {
                Console.WriteLine(persons[i].Description());
            }
        }
    }
    public Person()
    {
        firstName = "";
        lastName = "";
    }

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string firstName { get; protected set; }
    public string lastName { get; protected set; }

    abstract public string Description();
}

class Worker : Person
{
    public Worker() : base()
    {
        Reward = 0;
    }

    public Worker(string firstName, string lastName, double reward) : base(firstName, lastName)
    {
        Reward = reward;
    }

    public double Reward { get; protected set; }

    public override string Description()
    {
        return firstName + " " + lastName + " " + ", rewards: " + Reward;
    }
}

class Student : Person
{
    public Student() : base()
    {
        Semester = 1;
    }

    public Student(string firstName, string lastName, byte semester) : base(firstName, lastName)
    {
        Semester = semester;
    }

    public byte Semester { get; protected set; }

    public override string Description()
    {
        return firstName + " " + lastName + " " + ", semester: " + Semester;
    }
}