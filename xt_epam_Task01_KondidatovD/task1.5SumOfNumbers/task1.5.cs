using System;

namespace task1_5
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 1.5 for XT_EPAM" + "\n\r--------------------");
            int i = 0;
            int n = 1000;
            int sum = 0;

            //Если элемент кратен 5 или 3, то суммируем
            while (i < n)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
                i++;
            }
            //Выводим значение
            Console.WriteLine($"Sum of numbers = {sum}");
        }
    }
}
