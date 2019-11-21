using System;
using System.Text;

namespace task1_3
{
    public class Program
    {
        public static void Main()
        {
            int n = 1;
            //Получаем значение N с консоли и инициализируем стрингбилдер
            Console.WriteLine("Task 1.3 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Enter number of rows");
            n = OtherClasses.InputFromConsole.IsInteger();
            Console.WriteLine("\n\r");
            StringBuilder tree = new StringBuilder();
            tree.Append("*");
            int j = 1;
            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(n-j,Console.CursorTop);
                Console.WriteLine(tree);
                tree.Append("**");                
                j++;
            }
            return;
        }
    }
}
