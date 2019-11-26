using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_4
{
    public class Program
    {
        public static void Main()
        {


        }
    }

    public class MyString
    {
        char[] Str;

        public string GetString()
        {
            return Convert.ToString(Str);
        }

        public char[] Concat(char[] Str, char input)
        {
            Str.Append(input);
            return Str;
        }
        public char[] Concat(char[] Str, char[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Str.Append(input[i]);
            }
            return Str;
        }
        public char[] Concat(char[] Str, string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Str.Append(input[i]);
            }
            return Str;
        }

        public void Find(char key, out int position)
        {
            position = findChar(key);
            if (position == 0)
            {
                Console.WriteLine("Key is not finded");
            }
            else
            {
                Console.WriteLine($"Char's position is: {position}");
            }
        }
        private int findChar(char key)
        {
            int position = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i] == key)
                {
                    position = i + 1;
                    break;
                }
            }
            return position;
        }

        public MyString() : this("")
        {
        }
        public MyString(char[] str)
        {
            Str = str;
        }
        public MyString(string str)
        {
            for (int i = 0; i < str.Length; i++)
                Str.Append(str[i]);
        }  
    }
}
