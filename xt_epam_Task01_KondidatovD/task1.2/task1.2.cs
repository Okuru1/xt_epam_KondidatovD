using System;
using System.Text;


namespace task1_2
{
    public class Program
    {
        public static void Main()
        {
            int n = 1;
            Console.WriteLine("Task 1.2 for XT_EPAM" + "\n\r--------------------");
            Console.WriteLine("Enter number of rows");
            n= OtherClasses.InputFromConsole.IsInteger(); 
            Console.WriteLine("\n\r");
            StringBuilder tree = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                tree.Append("*");
                Console.WriteLine($"{i+1} " + tree);
            }
            return;
        }
    }
}

