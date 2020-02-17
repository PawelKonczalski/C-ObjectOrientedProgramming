using System;

namespace Namespace
{
    class Program
    {
        public static double PI = 3.14;
        public Program()
        {
            Console.WriteLine("I'm constructor from namespace 'Namespace'");
        }
        static void Main(string[] args)
        {
            global::Program zm = new global::Program();
            // MyNamespace.Program zm = new MyNamespace.Program();
            // Program nazwa_zm = new Program();
            Console.WriteLine("Test");
            Console.ReadLine();
        }
    }
}

// namespace MyNamespace
// {
    class Program
    {
        private double c = Namespace.Program.PI;
        public Program()
        {
            Console.WriteLine("I'm constructor from global namespace " + c);
        }
    }
// }