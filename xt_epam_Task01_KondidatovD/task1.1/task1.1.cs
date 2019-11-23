using System;
using OtherClasses;

namespace task1_1
{
    //Несмотря на ограничение на ввод исключительно целых положительных чисел, 
    //я реализовал возможность ввода ещё и вещественных значений.

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 1.1 for XT_EPAM"+"\n\r--------------------");
            Console.WriteLine("Enter X");
            double x = InputFromConsole.IsDouble();
            Console.WriteLine("\n\rEnter Y");
            double y = InputFromConsole.IsDouble();
            RectangleSquare(x, y);
            return;
            
        }
        private static double RectangleSquare(double a, double b)
        {
            double square = a*b;
            Console.WriteLine("\n\r"+$"Square Rectangle is {square}");
            return square;
        }
    }
}
