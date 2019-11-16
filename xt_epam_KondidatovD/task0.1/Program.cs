using System;

namespace task0._1
{
    class Program
    {
        static void Function(int n)
        {
            //Выводим значения до N включительно
            for (int i = 0; i <= n; i++)
                Console.Write("{0} ", i);
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Enter N");
            //Считываем N во время вызова функции
            Function(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
