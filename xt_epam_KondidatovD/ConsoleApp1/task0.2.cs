using System;

namespace task0._2
{
    class Program
    {
        static bool SimpleNum(int n)
        {
            bool smp = true;
            //Осуществляем проверку числа с помощью цикла
            for (int i = 2; i < n; i++)
                //Если число делится на что-то кроме единицы и себя,
                //то число не простое
                if (n % i == 0) {
                    smp = false;
                    Console.WriteLine("Number isn't simple");
                    break;                    
                }                
                else
                {
                    Console.WriteLine("Number is simple");
                    break;
                }
            return smp;
        }

        static void Main(string[] args)
        {
            //Считываем N в момент запуска функции
            Console.WriteLine("Enter N");
            SimpleNum(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
