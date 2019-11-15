using System;

namespace task0._1
{
    class Program
    {
        static void Function(int n)
        {
            for (int i = 0; i <= n; i++)
                Console.Write("{0} ", i);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            Function(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
