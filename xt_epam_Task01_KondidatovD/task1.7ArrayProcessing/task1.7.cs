﻿using System;
using OtherClasses;
namespace task1_7
{
    public class Program
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Task 1.7 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Choose array type: "
                + "\n\r1 - Array of Integer"
                + "\n\r2 - Array of Double");
            n = InputFromConsole.IsInteger(true);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the number of elements in the Integer array");
                    n = InputFromConsole.IsInteger(true);
                    int[] intArray = Arrays.CreateArray(n,n,false,true);
                    MaxElement.Max(intArray,true);
                    Arrays.QSort.Start(ref intArray, 0, n - 1);
                    for (int i = 0; i < n; i++)
                        Console.Write($"{intArray[i]} ");
                    break;
                case 2:
                    Console.WriteLine("Enter the number of elements in the Double array");
                    n = InputFromConsole.IsInteger(true);
                    double[] doubArray = Arrays.CreateDoubleArray(n,n,false,true);
                    MaxElement.Max(doubArray,true);
                    Arrays.QSort.Start(ref doubArray, 0, n - 1);
                    for (int i = 0; i < n; i++)
                        Console.Write($"{doubArray[i]:F4} ");
                    break;
            }            
        }
    }
}