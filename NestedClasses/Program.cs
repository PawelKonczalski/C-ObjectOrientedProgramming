using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Console.WriteLine(car.enginePower());
    }
}

class Car
{
    private class Engine
    {
        public Engine(uint power = 10)
        {
            this.power = power;
            Console.WriteLine("Engine");
        }
        public uint power;
    }
    public Car()
    {
        engine = new Engine();
        Console.WriteLine("Car");
    }

    public uint enginePower()
    {
        return this.engine.power;
    }
    
    private Engine engine;
}
