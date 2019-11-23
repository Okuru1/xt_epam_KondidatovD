using System;

namespace task1_6
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 1.6 for XT_EPAM" + "\n\r--------------------");
            int c = 0;
            bool[] properties = new bool[3];
            do
            {
                showTextProperties(properties);
                c = OtherClasses.InputFromConsole.IsInteger(true);
                switch (c)
                {
                    case 1:
                        properties[0] = !properties[0];
                        break;
                    case 2:
                        properties[1] = !properties[1];
                        break;
                    case 3:
                        properties[2] = !properties[2];
                        break;
                }
            } while (c != 0);
        }

        static void showTextProperties(bool[] properties)
        {
            Console.WriteLine("Text Properties is: ");
            //Если свойства не выбраны, то выводим None
            if (!(properties[0] || properties[1] || properties[2]))
            {
                Console.Write(Fonts.None.ToString() + " ");
            }
            //Иначе проверяем булевый массив и в соответствии со значениями выводим записи о форматах текста
            else
            {
                if (properties[0])
                    Console.Write(Fonts.Bold.ToString() + " ");
                if (properties[1])
                    Console.Write(Fonts.Italic.ToString() + " ");
                if (properties[2])
                    Console.Write(Fonts.Underline.ToString() + " ");
            }
            //Вывод меню выбора свойств шрифта
            Console.WriteLine("\n\rSelect Text Properties: "
                + "\n\r 1: Bold"
                + "\n\r 2: Italic"
                + "\n\r 3: Underline"
                + "\n\r 0 to exit");
        }

        enum Fonts
        {
            Bold = 1,
            Italic,
            Underline,
            None
        }
    }
}

