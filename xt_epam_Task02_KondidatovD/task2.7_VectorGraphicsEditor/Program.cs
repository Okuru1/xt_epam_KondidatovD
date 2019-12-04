using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_7
{
    public class Program
    {
        public static void Main()
        {


        }
    }

    internal class Point
    {
        internal int X { get; set; }
        internal int Y { get; set; }        
    }

    internal abstract class Figure
    {
        protected Point[] points;
        public abstract void Show();

        internal double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Abs(Math.Pow((p2.X - p1.X), 2)) + Math.Abs(Math.Pow((p2.y - p1.y), 2)));
        }

        //public abstract void Create();
    }

    class Line : Figure
    {
        public double Length { get; private set; }
        public Line(Point from, Point to)
        {            
            points = new Point[2] { from, to };
            Length = Distance(points[0], points[1]);
        }

        public override void Show()
        {
            for (int i = 0; i < Length; i++)
            {

            }
                

        }
    }

}
