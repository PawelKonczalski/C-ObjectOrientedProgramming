using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 0;
        string c;

        c = Console.ReadLine();

        try
        {
            // Console.WriteLine(a / b);
            if (a == 10)
            {
                throw new OurNameException("and was equal to 10");
            }
            int tmp = Convert.ToInt32(c);
            Console.WriteLine(a / tmp);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            // throw;
        }
        finally
        {
            Console.WriteLine("message at the end of the program " +
                              "regardless of whether an exception " +
                              "occurs");
        }
    }
}

class OurNameException : Exception
{
    public OurNameException(string? message) : base(message)
    {
    }
}