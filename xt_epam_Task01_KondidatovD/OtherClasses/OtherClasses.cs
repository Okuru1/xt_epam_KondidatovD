﻿using System;

namespace OtherClasses
{
    /// <summary>
    /// Ввод данных через консоль с проверками на корректный ввод  
    /// </summary>
    public class InputFromConsole
    {
        /// <summary>
        /// Ввод целочисленных значений со встроенными проверками на корректный ввод  
        /// </summary>
        /// <param name="includeNull">true - включение нуля в область допустимых значений</param>
        /// <param name="forMenu">true - вывод сообщения применимого в меню программы</param>
        /// <returns></returns>
        public static int IsInteger(bool includeNull=false, bool forMenu=false)
        {
            int input = 0;
            bool check = false;
            //Проверка вводимых числовых значений >= 0, пока пользователь не введёт корректные значения
            if (includeNull)
                while (!check)
                {
                    if (int.TryParse(Console.ReadLine(), out input))
                        if (input >= 0)
                            check = true;
                        else
                        {
                            //Вывод сообщения об ошибке при использовании в меню, либо в другой части программы.
                            if (forMenu) Console.WriteLine("Choose one of the options");
                            else Console.WriteLine("Enter the correct data");
                        }
                }
            //Проверка вводимых числовых значений > 0, пока пользователь не введёт корректные значения
            else
                while (!check)
                {
                    if (int.TryParse(Console.ReadLine(), out input))
                        if (input > 0)
                            check = true;
                        else
                            Console.WriteLine("Enter the correct data");
                }
            return input;
        }
        public static double IsDouble()
        {
            double input = 0;
            bool check = false;
            //Проверка вводимых числовых значений > 0, пока пользователь не введёт корректные значения
            while (!check)
            {
                if (Double.TryParse(Console.ReadLine(), out input))
                    if (input > 0)
                        check = true;
                    else
                        Console.WriteLine("Enter the correct data");
            }
            return input;
        }
    }
   
    /// <summary>
    /// Поиск максимального элемента в массиве
    /// </summary>
    public class MaxElement
    {
        public static int Max(int[] array, bool inConsole=false)
        {
            int max=array[0];
            for(int i=0; i<array.Length-1; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            if (inConsole)
                    Console.WriteLine($"\n\r{max} - is Max element in array");
            return max;
        }
        public static double Max(double[] array, bool inConsole = false)
        {
            double max = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            if (inConsole)
                Console.WriteLine($"\n\r{max:F4} - is Max element in array");
            return max;
        }
    }
    
    /// <summary>
    /// Класс для работы с массивами
    /// </summary>
    public class Arrays
    {
        /// <summary>
        /// Инициализация целочисленного массива
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="randomValue">Верхний порог случайного значения</param>
        /// <param name="inConsole">Вывод в консоль</param>
        /// <returns></returns>
        public static int[] CreateArray(int size, int randomValue, bool inConsole = false)
        {
            Random r = new Random();
            int[] array = new int[size];
            for (int i = 0; i<size;i++)
            {
                array[i]=r.Next(randomValue);
            }
            if (inConsole)
                for (int i = 0; i < size; i++)
                    Console.Write($"{array[i]} ");
            return array;
        } 
        
        /// <summary>
        /// Инициализация вещественного массива
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="randomValue">Верхний порог случайного значения</param>
        /// <param name="inConsole">Вывод в консоль</param>
        /// <returns></returns>
        public static double[] CreateDoubleArray(int size, int randomValue, bool inConsole = false)
        {
            Random r = new Random();
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(randomValue)*r.NextDouble();
            }
            if (inConsole)
                for (int i = 0; i < size; i++)
                    Console.Write($"{array[i]:F4} ");
            return array;
        }
       
        /// <summary>
        /// Быстрая сортировка
        /// </summary>
        public class QSort
        {
            //Разделение исходного массива на подмассивы и их сортировка
            private static int partition(ref int[] array, int start, int end)
            {
                int temp;
                int marker = start;
                for (int i = start; i < end; i++)
                {
                    if ( array[i] <  array[end])
                    {
                        temp = array[marker];
                        array[marker] = array[i];
                        array[i] = temp;
                        marker++;
                    }
                }
                temp = array[marker];
                array[marker] = array[end];
                array[end] = temp;
                return marker;
            }
            private static int partition(ref double[] array, int start, int end)
            {
                double temp;
                int marker = start;
                for (int i = start; i < end; i++)
                {
                    if (array[i] < array[end])
                    {
                        temp = array[marker];
                        array[marker] = array[i];
                        array[i] = temp;
                        marker++;
                    }
                }
                temp = array[marker];
                array[marker] = array[end];
                array[end] = temp;
                return marker;
            }
            /// <summary>
            /// Быстрая сортировка одномерного массива
            /// </summary>
            /// <param name="array">Входной массив</param>
            /// <param name="start">Левая граница диапазона сортировки</param>
            /// <param name="end">Правая граница диапазона сортировки</param>
            //Старт рекурсии с заданными параметрами
            public static void Start(ref double[] array, int start, int end, bool inConsole = false) 
            {
                if (start >= end)
                {
                    //if (inConsole) 
                    //{
                    //    Console.WriteLine("Sorted array: ");
                    //    for(int i=0;i<array.Length-1;i++)
                    //        Console.WriteLine($"{array[i]} ");
                    //}
                    return;
                }
                int pivot = partition(ref array, start, end);
                Start(ref array, start, pivot - 1);
                Start(ref array, pivot + 1, end);
            }
            public static void Start(ref int[] array, int start, int end, bool inConsole = false)
            {
                if (start >= end)
                {
                    //if (inConsole) 
                    //{
                    //    Console.WriteLine("Sorted array: ");
                    //    for(int i=0;i<array.Length-1;i++)
                    //        Console.WriteLine($"{array[i]} ");
                    //}
                    return;
                }
                int pivot = partition(ref array, start, end);
                Start(ref array, start, pivot - 1);
                Start(ref array, pivot + 1, end);
            }
            /// <summary>
            /// Быстрая сортировка двумерного массива
            /// </summary>
            /// <param name="arr">Входной двумерный массив</param>
            //Преобразование матрицы во временный одномерный массив, сортировка и обратное преобразование
            public static void StartForMatrix(int[,] arr)
            {
                int n = arr.GetLength(0);
                int m = arr.GetLength(1);
                int count = 0;
                int[] temp = new int[n * m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        temp[count] = arr[i, j];
                        count++;
                    }
                Start(ref temp, 0, (n * m) - 1);
                count = 0;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = temp[count];
                        count++;
                    }
            }
        }
    }
}