using System;

class Program
{
    public enum TimeOfDay
    {
        Morning,
        Afternoon,
        Evening
    }

    public static string getGreetings(TimeOfDay time)
    {
        switch (time)
        {
            case TimeOfDay.Morning: return "Good morning";
            case TimeOfDay.Afternoon: return "Good afternoon";
            case TimeOfDay.Evening: return "Good evening";
            default: return "Something went wrong";
        }
    }

    static void Main(string[] args)
    {
        TimeOfDay a = TimeOfDay.Morning;
        Console.WriteLine(getGreetings(a));
    }
}