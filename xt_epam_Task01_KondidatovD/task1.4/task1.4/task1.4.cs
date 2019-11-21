using System;
using System.Text;

namespace task1_4
{
   public class Program
    {
        public static void Main()
        {
            int n = 1;
            Console.WriteLine("Task 1.4 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Enter number of rows");
            //Получаем значение N с консоли и инициализируем стрингбилдер
            n = OtherClasses.InputFromConsole.IsInteger();
            Console.WriteLine("\n\r");
            StringBuilder tree = new StringBuilder();
            //Используя вложенный цикл выводим заданное количество треугольников.
            //m - счётчик строк в треугольниках, увеличивается с каждым повторением пока не станет равен n
            //n - количество треугольников и количество строк в последнем
            int m = 1, tab;
            for (int i = 0; i < n; i++)
            {
                tab = 0;
                tree.Append("*");
                for (int j = 0; j < m; j++)
                {
                    //Строим j-ый треугольник с j количеством строк
                    Console.SetCursorPosition(n - tab, Console.CursorTop);
                    Console.WriteLine(tree);
                    tree.Append("**");
                    tab++;
                }
                //Очищаем массив для построения следущего треугольника
                tree.Clear();
                m++;
            }
            return;
        }
    }
}
