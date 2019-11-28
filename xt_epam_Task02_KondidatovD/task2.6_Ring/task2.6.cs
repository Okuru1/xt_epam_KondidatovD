using System;
using OtherClasses;


namespace task2_6
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 2.6 for XT_EPAM" + "\n\r--------------------");
            int x;
            int y;
            double innR,outR;

            Console.WriteLine("Enter X:");
            x = InputFromConsole.IsInteger();
            Console.WriteLine("Enter Y:");
            y = InputFromConsole.IsInteger();
            Console.WriteLine("Enter inner R:");
            innR = InputFromConsole.IsDouble();
            Console.WriteLine("Enter outer R:");
            outR = InputFromConsole.IsDouble();

            Point center = new Point(x, y);

            Round innerRound = new Round(center, innR);
            Round outerRound = new Round(center, outR);

            outerRound.GetInfo();
            innerRound.GetInfo();

            Ring myRing = new Ring(innerRound, outerRound);

            myRing.GetInfo();
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

    public class Round
    {
        public Point Center;
        public double R;

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
            Center.X = x;
            Center.Y = y;
            R = r;
        }
        public Round(Point center, double r)
        {
            Center = center;
            R = r;
        }
    }  

    public class Ring
    {
        private Round Inner;
        private Round Outer;

        public double RingSquare()
        {
            return Outer.GetSquare() - Inner.GetSquare();
        }

        public double SumOfCircumferences()
        {
            return Inner.GetCircumference() + Outer.GetCircumference();
        }
       
        public void GetInfo()
        {
            Console.WriteLine("\n\rRing Information: " 
                + $"\n\rX = {Inner.Center.X}"
                + $"\n\rY = {Inner.Center.Y}"
                + $"\n\rInner R = {Inner.R:F4}"
                + $"\n\rOuter R = {Outer.R:F4}"
                + $"\n\rSquare of Ring = {RingSquare():F4}"
                + $"\n\rSum of Circumferences = {SumOfCircumferences():F4}");
        }

        public Ring (Round firstRound, Round secondRound)
        {
            if (firstRound.GetRadius() < secondRound.GetRadius())
            {
                Inner = firstRound;
                Outer = secondRound;
            }
            else
            {
                Inner = secondRound;
                Outer = firstRound;
            }
        }
    }
}
