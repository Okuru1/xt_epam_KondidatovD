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

            Round innerRound = new Round(center);
            innerRound.Radius = innR;
            Round outerRound = new Round(center);
            outerRound.Radius = outR;
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
                + $"\n\rInner R = {Inner.Radius:F4}"
                + $"\n\rOuter R = {Outer.Radius:F4}"
                + $"\n\rSquare of Ring = {RingSquare():F4}"
                + $"\n\rSum of Circumferences = {SumOfCircumferences():F4}");
        }

        public Ring (Round firstRound, Round secondRound)
        {
            if (firstRound.Radius < secondRound.Radius)
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
