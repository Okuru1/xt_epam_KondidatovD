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

            Round Circle = new Round(x, y, r);

            Circle.GetInfo();
        }
    }
    
    public class Round
    {
        private int X;
        private int Y;
        private double R;

        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
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
            return Math.PI * (r*r);
        }

        public void GetInfo()
        {
            Console.WriteLine($"X = {X}");
            Console.WriteLine($"Y = {Y}");
            Console.WriteLine($"R = {R:F4}");
            Console.WriteLine($"Circumference = {GetCircumference():F4}");
            Console.WriteLine($"Square of Circle = {GetSquare():F4}");
        }

        public Round(int x, int y, double r)
        {
            X = x;
            Y = y;
            R = r;
        }
    }
};
