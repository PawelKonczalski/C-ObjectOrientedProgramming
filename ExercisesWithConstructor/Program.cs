using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Welcome.Message);
        
        Car car = new Car("Volvo", 2);
        // Car car2 = car;
        Car car2 = new Car(car);
        car2.Description = "Audi";
        Console.WriteLine(car.NrOfWheels);
        Console.WriteLine(car.Description);
        Console.WriteLine(car2.Description);
    }
}

class Welcome
{
    public static string Message
    {
        get;
        set;
    }

    static Welcome()
    {
        DateTime now = DateTime.Now;
        if (now.Hour < 19)
        {
            Message = "Good morning";
        }
        else
        {
            Message = "Good afternoon";
        }
    }
}

class Car
{
    public string Description
    {
        get;
        set;
    }

    public int NrOfWheels
    {
        get;
        private set;
    }

    public Car(string description, int nrOfWheels = 4)
    {
        Description = description;
        NrOfWheels = nrOfWheels;
    }

    public Car(string description) : this(description, 4)
    {
        Console.WriteLine("Check");
    }

    public Car(Car car)
    {
        this.Description = car.Description;
        this.NrOfWheels = car.NrOfWheels;
    }
}