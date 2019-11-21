using System;
using OtherClasses;

namespace task1_10
{
    public class Program
    {
        public static void Main()
        {
            int n,m,sum=0;
            Console.WriteLine("Task 1.10 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Enter array size: \n\rN x M ");
            n = InputFromConsole.IsInteger();
            m = InputFromConsole.IsInteger();
            int [,] array = Arrays.CreateArray(n, m, n*10, false, true);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if ((i+j)%2==0)
                        sum += array[i, j];
            Console.WriteLine($"Summ of even elements is: \n\r{sum}");
        }
    }
}
