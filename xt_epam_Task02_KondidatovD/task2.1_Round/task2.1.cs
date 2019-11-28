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

            Round Circle = new Round(x, y, r);
            Round Circle2 = new Round(p1, r);

            Circle.GetInfo();
            Circle2.GetInfo();
        }
    }

    public class Round
    {
        private Point Center;
        private double R;

        public int GetX()
        {
            return Center.X;
        }
        public int GetY()
        {
            return Center.Y;
        }
        public double GetRadius()
        {
            return R;
        }

        public double GetCircumference()
        {
            return circumference(R);
        }
        private double circumference(double r)
        {
            return 2 * Math.PI * r;
        }

        public double GetSquare()
        {
            return square(R);
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
                + $"\n\rR = {R:F4}"
                + $"\n\rCircumference = {GetCircumference():F4}"
                + $"\n\rSquare of Circle = {GetSquare():F4}");
        }

        public Round(int x, int y, double r)
        {
            Center = new Point(x, y);
            R = r;
        }
        public Round(Point center, double r)
        {
            Center = center;
            R = r;
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
