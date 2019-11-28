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
            MyString stringOne = new MyString('s','r','e');
            char c = 's';
            stringOne.Append(c);
            string str = stringOne.GetString();
            Console.WriteLine(str);
            stringOne.Concat(str);
            stringOne.Concat(str);
            stringOne.Concat(str);
            stringOne.Concat('a', 'b', 'c');
            str = stringOne.GetString();
            Console.WriteLine(str);
        }
    }

    public class MyString
    {
        private char[] Str;
        private int Elements;

        public string GetString()
        {
            string result = new string(Str);
            return result; 
        }

        public char[] Append(char input)
        {
            Str = memoryReserve(Elements+1);
            Str[Elements] = input;            
            Elements++;
            return Str;
        }

        public char[] Concat(params char[] input)
        { 
            Str = memoryReserve(Elements + input.Length);
            for (int i = 0; i < input.Length; i++)  
            {
                Str[Elements] = input[i];
                Elements++;
                if (input[i] == '\0')
                    break;

            }
            return Str;
        }
        public char[] Concat(string input)
        {            
            int i = 0;
            Str = memoryReserve(Elements + input.Length);
            while ((input[i] != '\0') && (i < input.Length))
            {
                Str[Elements] = input[i];
                Elements++;
                i++;
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

        private char[] memoryReserve(int inputLength)
        {
            int strLength;

            strLength = Str?.Length ?? 8;

            if (Str == null)
            {
                while (strLength < inputLength)
                    strLength *= 2;
                return new char[strLength];
            }
            else
            {
                if (strLength < inputLength)
                {
                    while (strLength < inputLength)
                        strLength *= 2;
                    char[] temp = new char[strLength];
                    for (int i = 0; i < Elements; i++)
                        temp[i] = Str[i];
                    return temp;
                }
                else
                    return Str;
            }
        }
        
        public MyString(params char[] input)
        {
            if (input.Length != 0)
            {
                Str = memoryReserve(input.Length);
                for (int i = 0; i < input.Length; i++)
                {
                    Str[i] = input[i];
                    Elements++;
                }
            } 
            else
            {
                Str = new char[8];
                Elements = 0;
            }
        }
        public MyString(string str)
        {
            Str = memoryReserve(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                Str[i] = str[i];
                Elements++;
            }     
        } 
    }
}
