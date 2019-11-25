using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1
{
    public class Program
    {
        public static void Main()
        {
            Round Circle = new Round(1,2);            

            Console.WriteLine(Convert.ToString(Circle.getCenter()));
            Console.WriteLine(Convert.ToString(Circle.getRadius()));
            Console.WriteLine(Convert.ToString(Circle.getCircumference()));
            Console.WriteLine(Convert.ToString(Circle.getSquare()));

        }


    }

    public class Round
    {
        int Center;
        double Radius;

        public int getCenter()
        {
            return Center;
        }
        public double getRadius()
        {
            return Radius;
        }

        public double getCircumference() 
        {
            return circumference(Radius);
        } 
        private double circumference(double r)
        {
            return 2 * Math.PI * r;
        }

        public double getSquare()
        {
            return square(Radius);
        }
        private double square(double r)
        {
            return 2 * Math.PI * (r*r);
        }

        public Round(int c, double r) 
        {
            Center = c;
            Radius = r;
        }
    }
};
