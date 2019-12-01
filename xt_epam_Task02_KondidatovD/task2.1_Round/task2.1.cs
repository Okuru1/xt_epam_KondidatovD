using System;
using OtherClasses;

namespace task2_1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 2.1 for XT_EPAM" + "\n\r--------------------");
            int x;
            int y;
            double r;

            Console.WriteLine("Enter X:");
            x = InputFromConsole.IsInteger();
            Console.WriteLine("Enter Y:");
            y = InputFromConsole.IsInteger();
            Console.WriteLine("Enter R:");
            r = InputFromConsole.IsDouble();

            Point p1 = new Point(x, y);

            Round Circle = new Round(x, y);
            Round Circle2 = new Round(p1);

            Circle.GetInfo();
            Circle2.GetInfo();
        }
    }

    public class Round
    {
        public readonly Point Center;
        private double _radius;
        
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Radius. Radius cannot be negative or zero.", "Radius");
                _radius = value;
            }
        }

        public double GetCircumference()
        {
            return circumference(_radius);
        }
        private double circumference(double r)
        {
            return 2 * Math.PI * r;
        }

        public double GetSquare()
        {
            return square(_radius);
        }
        private double square(double r)
        {
            return Math.PI * (r * r);
        }

        public void GetInfo()
        {
            Console.WriteLine($"\n\rRound Information:"
                + $"\n\rX = {Center.X}"
                + $"\n\rY = {Center.Y}"
                + $"\n\rR = {_radius:F4}"
                + $"\n\rCircumference = {GetCircumference():F4}"
                + $"\n\rSquare of Circle = {GetSquare():F4}");
        }

        public Round(int x, int y)
        {
            Center = new Point(x, y);
        }

        public Round(Point center)
        {
            Center = center;
        }
    }
    
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
};
