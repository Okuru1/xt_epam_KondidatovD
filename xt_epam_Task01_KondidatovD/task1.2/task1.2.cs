using System;
using System.Text;


namespace task1_2
{
    public class Program
    {
        public static void Main()
        {
            int n = 1;
            Console.WriteLine("Task 1.2 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Enter number of rows");
            n = OtherClasses.InputFromConsole.IsInteger(); //получаем количество этажей в треугольнике
            Console.WriteLine("\n\r");
            buildTriangle(n);            
        }

        //Инициализируем стрингбилдер и выводим его в консоль в виде прямоугольного треугольника,
        //увеличивая количество "*" на 1 на каждой итерации.
        static void buildTriangle(int rowsCount)
        {
            StringBuilder tree = new StringBuilder();
            for (int i = 0; i < rowsCount; i++)
            {
                tree.Append("*");
                Console.WriteLine($"{i + 1} " + tree);
            }            
        }
    }
}

