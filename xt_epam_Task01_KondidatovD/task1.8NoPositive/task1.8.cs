using System;
using OtherClasses;

namespace task1_8
{ 
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 1.8 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Enter size of array: ");
            int size = InputFromConsole.IsInteger();
           
            int[,,] array = new int[size, size, size];
            FullAndShowCube(ref array, true);
            NoPositive(ref array);
        }

        private static void NoPositive(ref int[,,] array)
        {
            Console.WriteLine("No Positive array: ");
            int size = array.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
                            Console.Write($"{array[i, j, k]} ");
                            Console.ResetColor(); // сбрасываем в стандартный
                        }
                        else
                            Console.Write($"{array[i, j, k]} ");
                    }
                    Console.WriteLine("\n\r");
                }
                Console.WriteLine("\n\r");
            }


        }

        private static void FullAndShowCube(ref int[,,] array, bool fullArray=false)
        {
            Console.WriteLine("Created array: ");
            Random r = new Random();
            int size = array.GetLength(0);        
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        if (fullArray)
                        {
                            array[i, j, k] = r.Next(200) - 100;
                        }
                        if (array[i, j, k] > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                            Console.Write($"{array[i, j, k]} ");
                            Console.ResetColor(); // сбрасываем в стандартный
                        }
                        else
                            Console.Write($"{array[i, j, k]} ");
                    }
                    Console.WriteLine("\n\r");
                }
                Console.WriteLine("\n\r");
            }
        }
    }
}
