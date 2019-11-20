using System;

namespace OtherClasses
{
    //Класс, в котором содержатся методы ввода значений через консоль с проверкой
    class InputFromConsole
    {   
        /// <summary>
        /// Метод ввода данных со встроенными проверками на ввод корректных значений
        /// </summary>
        /// <param name="includeNull">true - включение нуля в область допустимых значений</param>
        /// <param name="forMenu">true - вывод сообщения применимого в меню программы</param>
        /// <returns></returns>
        public static int IsInteger(bool includeNull=false, bool forMenu=false)
        {
            int input = 0;
            bool check = false;
            //Проверка вводимых числовых значений >= 0, пока пользователь не введёт корректные значения
            if (includeNull)
                while (!check)
                {
                    if (Int32.TryParse(Console.ReadLine(), out input))
                        if (input >= 0)
                            check = true;
                        else
                        {
                            //Вывод сообщения об ошибке при использовании в меню, либо в другой части программы.
                            if (forMenu) Console.WriteLine("Choose one of the options");
                            else Console.WriteLine("Enter the correct data");
                        }
                }
            //Проверка вводимых числовых значений > 0, пока пользователь не введёт корректные значения
            else
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