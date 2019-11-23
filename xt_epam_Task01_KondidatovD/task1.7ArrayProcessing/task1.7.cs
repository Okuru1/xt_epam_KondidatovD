using System;
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
                    processingIntegerArray();
                    break;
                case 2:
                    processingDoubleArray();
                    break;
            }            
        }

        static void processingIntegerArray() 
        {
            int n;
            Console.WriteLine("Enter the number of elements in the Integer array");
            n = InputFromConsole.IsInteger(true);//считываем количество элементов
            int[] intArray = Arrays.CreateArray(n, n, false, true); //создаем массив
            MaxElement.Max(intArray, true);//определяем и выводим максимальный элемент
            Arrays.QSort.Start(ref intArray, 0, n - 1); //сортируем массив
            for (int i = 0; i < n; i++)//выводим массив
                Console.Write($"{intArray[i]} ");
        }

        static void processingDoubleArray()
        {
            int n;
            Console.WriteLine("Enter the number of elements in the Double array");
            n = InputFromConsole.IsInteger(true); //считываем количество элементов
            double[] doubArray = Arrays.CreateDoubleArray(n, n, false, true); //создаем массив
            MaxElement.Max(doubArray, true); //определяем и выводим максимальный элемент
            Arrays.QSort.Start(ref doubArray, 0, n - 1); //сортируем массив
            for (int i = 0; i < n; i++) //выводим массив
                Console.Write($"{doubArray[i]:F4} ");
        }

    }
}
