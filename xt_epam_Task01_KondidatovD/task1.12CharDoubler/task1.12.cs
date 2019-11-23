using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_12
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 1.12 for XT_EPAM" + "\n\r--------------------");
            string inputOne;
            string inputTwo;
            Console.WriteLine("Enter the first line: ");
            inputOne = Console.ReadLine();
            Console.WriteLine("Enter the second line: ");
            inputTwo = Console.ReadLine();
            string doubled = CharDoubler(inputOne,inputTwo);
            Console.WriteLine("Result: ");
            Console.Write(doubled);
        }

        static string CharDoubler(string mainString, string addString)
        {
            StringBuilder result =new StringBuilder();
            for (int i = 0; i < mainString.Length; i++)
            {
                result.Append(mainString[i]);
                for (int j = 0; j < addString.Length; j++)
                    if (mainString[i] == addString[j])
                    {
                        result.Append(addString[j]);
                        break;
                    }             
            }
            return result.ToString();
        }
    }
}
