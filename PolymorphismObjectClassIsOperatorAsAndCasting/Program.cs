using System;

namespace PolymorphismObjectClassIsOperatorAsAndCasting
{
    class Program
    {
        static void Display(Point p)
        {
            // if(p is Point3D)
            // Console.WriteLine(((Point3D)p).getPoint());
            // else
            //     Console.WriteLine(p.getPoint());
            
            Point3D p3d = p as Point3D;
            if (p3d == null)
            {
                Console.WriteLine(p.getPoint());
            }
            else
            {
                Console.WriteLine(p3d.getPoint());
            }
        }

        static string getClassName(Object x)
        {
            return x.ToString();
        }
        
        static void Main(string[] args)
        {
            Point a;
            Point b;
            Point3D c = new Point3D(50,100,150);
            
            a = new Point(1,5);
            Console.WriteLine(a.getPoint());
            
            b = new Point3D(5,10,15);
            Console.WriteLine(((Point3D)b).getPoint());
            
            Display(a);
            Display(b);
            Display(c);
            
            Console.WriteLine(getClassName(a));
            Console.WriteLine(getClassName(b));
            Console.WriteLine(getClassName(c));
        }
    }
}