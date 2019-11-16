using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0._3
{
    class Program
    {
        static void Square(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Enter an odd number!");   
            }
            else {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if ((j == ((n + 1) / 2)) && (i == ((n + 1) / 2)))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            Square(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
