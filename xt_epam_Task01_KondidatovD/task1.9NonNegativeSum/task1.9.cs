using System;
using OtherClasses;

namespace task1_9
{
    public class Program
    {
        public static void Main()
        {
            int n, value, sum;
            double dsum;
            Console.WriteLine("Task 1.9 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Choose array type: "
                + "\n\r1 - Array of Integer"
                + "\n\r2 - Array of Double");
            n = InputFromConsole.IsInteger(true);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the number of elements in the Integer array");
                    n = InputFromConsole.IsInteger(true);
                    int[] intArray = Arrays.CreateArray(n, n, true, true);
                    sum = Arrays.SummOfElements.IntPositiveSum(intArray, true);
                    break;
                case 2:
                    Console.WriteLine("Enter the number of elements in the Double array");
                    n = InputFromConsole.IsInteger(true);
                    double[] doubArray = Arrays.CreateDoubleArray(n, n, true, true);
                    dsum = Arrays.SummOfElements.DoubPositiveSum(doubArray, true);
                    break;
            }
        }
    }
}
