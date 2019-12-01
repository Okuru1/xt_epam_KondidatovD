using System;
using OtherClasses;

namespace task2_2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 2.2 for XT_EPAM" + "\n\r--------------------");
            double a, b, c;
            Console.WriteLine("Enter A:");
            a = InputFromConsole.IsDouble();
            Console.WriteLine("Enter B:");
            b = InputFromConsole.IsDouble();
            Console.WriteLine("Enter C:");
            c = InputFromConsole.IsDouble();

            Triangle triangle = new Triangle(a, b, c);
            triangle.GetInfo();          
        }
    }

    class Triangle
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;

        public Triangle (double a, double b, double c)
        {
            if ((a >= (b + c) || (b >= (a + c)) || (c >= (b + a))))
                throw new ArgumentException("A non-existent triangle is specified. Each side must be less than the sum of the other two");
            A = a;
            B = b;
            C = c;
        }    

        public double GetPerimeter()
        {
            return A + B + C;
        }

        public double GetSquare()
        {
            double p;
            p = halfPerimeter();
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }
        private double halfPerimeter()
        {
            return 1 % 2 * (A + B + C); 
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"A = {A:F2}");
            Console.WriteLine($"B = {B:F2}");
            Console.WriteLine($"C = {C:F2}");
            Console.WriteLine($"Perimeter = {GetPerimeter():F4}");
            Console.WriteLine($"Square of Triangle = {GetSquare():F4}");
        }
    }
}
