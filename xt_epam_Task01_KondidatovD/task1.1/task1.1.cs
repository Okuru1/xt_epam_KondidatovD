using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    //Класс, в котором содержатся методы ввода значений через консоль с проверкой
    class InputFromConsole
    {
        public static int IsInteger()
        {
            int input = 0;
            bool check = false;
            //Проверка вводимых числовых значений > 0, пока пользователь не введёт корректные значения
            while (!check)
            {
               if(Int32.TryParse(Console.ReadLine(), out input))
                    if (input > 0)
                    check = true;
                    else
                    Console.WriteLine("Enter the correct data");
            }
            return input;
        }
        public static double IsDouble()
        {
            double input = 0;
            bool check = false;
            //Проверка вводимых числовых значений > 0, пока пользователь не введёт корректные значения
            while (!check)
            {
                if (Double.TryParse(Console.ReadLine(), out input))
                    if (input > 0)
                        check = true;
                    else
                        Console.WriteLine("Enter the correct data");
            }
            return input;
        }
    }
}
