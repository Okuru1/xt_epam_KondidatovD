using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0._4
{

    public class QSort
    {
        //Разделение исходного массива на подмассивы и их сортировка
        private static int partition(int[] array, int start, int end)
        {
            int temp;
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

        //Старт рекурсии с заданными параметрами
        public static void Start(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            Start(array, start, pivot - 1);
            Start(array, pivot + 1, end);
        }

        //Преобразование матрицы во временный одномерный массив, сортировка и обратное преобразование
        public static void StartForMatrix( int[,] arr) 
        {
            
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);
            int count =0; 
            int[] temp = new int[n * m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    temp[count] = arr[i, j];
                    count++;
                }
            Start(temp, 0, (n * m)-1);
            count = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = temp[count];
                    count++;
                }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n=0,m=0,q=1;
            Console.WriteLine("1 or 2 ");
            q = Convert.ToInt32(Console.ReadLine());
            if (q == 1)
            {
                //Вводим размерность массива
                Console.WriteLine("Enter N");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter M");
                m = Convert.ToInt32(Console.ReadLine());
                int[,] arr = new int[n, m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        arr[i, j] = r.Next(1, 100);
            }
            else
            {
                int[] array = new int[n];
                Console.WriteLine("Enter N");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter M");
                    m = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < m; j++)
                        arr[i, j] = r.Next(1, 100);
                }

            }
            //Вывод неотсортированного массива
            Console.WriteLine("Unsorted array: ");
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("{0}",i);
                for (int j = 0; j < m; j++)
                    Console.Write("{0} ", arr[i, j]);
                Console.Write("\n");
            }
            Console.WriteLine("Sorted array: ");
            //Быстрая сортировка алгоритм собственной реализации. Взят из вступительного проекта.
            QSort.StartForMatrix(arr);
            
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("{0}",i);
                for (int j = 0; j < m; j++)
                    Console.Write("{0} ", arr[i,j]);
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}
