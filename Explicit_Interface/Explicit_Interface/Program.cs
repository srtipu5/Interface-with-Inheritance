using System;

namespace Explicit_Interface
{
    class Program:ICircle,ISquare
    {
        const double Pi = 3.1416; 
        static void Main(string[] args)
        {
            ISquare square = new Program();
            Console.Write("Enter the length of square : ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(square.Area(length));

            ICircle circle = new Program();
            Console.Write("Enter the radius of circle : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(circle.Area(radius));
        }

        double ICircle.Area(double radius)
        {
            return Pi * radius;  
        }

        double ISquare.Area(double side)
        {
            return side * side;
        }
    }
}
