using System;

namespace OtherClasses
{
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