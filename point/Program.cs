using System;

namespace point
{
    class Program
    {
        static void Main(string[] args)
        {
           Point2d p2 = new Point2d();
    
           p2.x=1;
           p2.y=2;
           Console.WriteLine(p2.ToString2d());

           Point3d p3 = new Point3d();

           p3.x=4;
           p3.y=5;
           p3.z=6;
           Console.WriteLine(p3.ToString3d());
           Console.WriteLine(p3.ToString2d());;
           Console.ReadLine();
        }
    }
}
