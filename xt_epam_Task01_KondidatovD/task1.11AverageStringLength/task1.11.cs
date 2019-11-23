using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_11
{
    public class Program
    {
        public static void Main()
        {
            string s;
            string[] arrayOfStrings;
            int average = 0;
            Console.WriteLine("Task 1.11 for XT_EPAM" + "\n\r--------------------");
            s = Console.ReadLine();
            StringBuilder str = new StringBuilder(s); 
            RemovePunctuation(ref str, true); //Удаляем знаки пунктуации 
            s = str.ToString();
            arrayOfStrings = s.Split(null as string[], StringSplitOptions.RemoveEmptyEntries);           
            if (arrayOfStrings.Length - 1 != 0)
            {
                for (int i = 0; i < arrayOfStrings.Length; i++)
                {
                    if (arrayOfStrings[i].Length != 0)
                    {
                        Console.Write($"{i}) {arrayOfStrings[i]}");
                        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                        Console.Write($"    [the length of string is { arrayOfStrings[i].Length }]\n\r");
                        Console.ResetColor(); // сбрасываем в стандартный                                         
                        average += arrayOfStrings[i].Length;
                    }
                }
                average /= (arrayOfStrings.Length);
                Console.WriteLine($"Аverage word length per line is {average}");
            }
            else
            {
                Console.WriteLine("You haven't enter the word");
            }
        }

        static void RemovePunctuation(ref StringBuilder inputString, bool inConsole = false)
        {
            for (int i = inputString.Length - 1; i >= 0; i--)
                if (char.IsPunctuation(inputString[i]))
                    inputString.Remove(i, 1);
            if (inConsole)
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.Write("All punctuation has removed \n\r");
                Console.ResetColor(); // сбрасываем в стандартный              
                Console.Write(inputString + "\n\r");
            }
        }
    }
}

