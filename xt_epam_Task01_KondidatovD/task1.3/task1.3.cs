using System;
using System.Text;

namespace task1_3
{
    public class Program
    {
        public static void Main()
        {
            int n = 1;
            Console.WriteLine("Task 1.3 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Enter number of rows");
            n = OtherClasses.InputFromConsole.IsInteger();
            Console.WriteLine("\n\r");
            buildAnIsoscelesTriangle(n);
        }

        //Инициализируем стрингбилдер и с его помощью выводим строку в виде равнобедренного треугольника,
        //увеличивая количество "*" на 2 на каждой итерации.
        static void buildAnIsoscelesTriangle(int rowsCount)
        {
            StringBuilder tree = new StringBuilder();
            tree.Append("*");
            int j = 1;
            for (int i = 0; i < rowsCount; i++)
            {
                //Устанавливаем позицию курсора на консоли для создания эффекта табуляции
                Console.SetCursorPosition(rowsCount - j, Console.CursorTop);
                Console.WriteLine(tree);
                tree.Append("**");
                j++;
            }
        }
    }
}
