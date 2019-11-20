using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_2
{
    public class Program
    {
        public static void Main()
        {
            int n = 1;
            Console.WriteLine("Task 1.2 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Enter number of rows");
            n=InputFromConsole.IsInteger(); 
            Console.WriteLine("\n\r");
            StringBuilder tree = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                tree.Append("*");
                Console.WriteLine($"{i+1} " + tree);
            }
            return;
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
                if (Int32.TryParse(Console.ReadLine(), out input))
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

