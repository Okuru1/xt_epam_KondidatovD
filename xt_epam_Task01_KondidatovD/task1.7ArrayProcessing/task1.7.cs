using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_7
{
    public class Program
    {
        public static void Main()
        {
            int n,value;
            Console.WriteLine("Task 1.7 for XT_EPAM" + "\n\r--------------------");
            Random rnd = new Random();
            Console.WriteLine("Choose array type: "
                + "\n\r1 - Array of Integer"
                + "\n\r2 - Array of Double");
            n = OtherClasses.InputFromConsole.IsInteger(true);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the number of elements in the Integer array");
                    n = OtherClasses.InputFromConsole.IsInteger(true);
                    value = n < 100 ? 100 : 1000;
                    int[] intArray = OtherClasses.Arrays.CreateArray(n,value,true);
                    OtherClasses.MaxElement.Max(intArray,true);
                    OtherClasses.Arrays.QSort.Start(ref intArray,0,n-1);
                    for (int i = 0; i < n; i++)
                        Console.Write($"{intArray[i]} ");
                    break;
                case 2:
                    Console.WriteLine("Enter the number of elements in the Double array");
                    n = OtherClasses.InputFromConsole.IsInteger(true);
                    value = n < 100 ? 100 : 1000;
                    double[] doubArray = OtherClasses.Arrays.CreateDoubleArray(n, value,true);
                    OtherClasses.MaxElement.Max(doubArray,true);
                    OtherClasses.Arrays.QSort.Start(ref doubArray, 0, n - 1);
                    for (int i = 0; i < n; i++)
                        Console.Write($"{doubArray[i]:F4} ");
                    break;
            }            
        }
    }
}
