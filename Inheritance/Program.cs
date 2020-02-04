using System;

class Program
{
    static void Main(string[] args)
    {
        Point point = new Point(5, 10);

        Console.WriteLine(point.getPoint());

        Point3D point3D = new Point3D(9, 4, 7);
        Console.WriteLine(point3D.getPoint());
    }
}