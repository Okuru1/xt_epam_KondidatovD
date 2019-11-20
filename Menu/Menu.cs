using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("XT_EPAM_2019 TASK-01 C# Basics by Kondidatov Dmitriy"
                    + "\n\rChoose Task: "
                    + "\n\rC# BASICS:"
                    + "\n\r1)  Task 1.1  - Rectangle"
                    + "\n\r2)  Task 1.2  - Triangle"
                    + "\n\r3)  Task 1.3  - Another Triangle"
                    + "\n\r4)  Task 1.4  - X-Mas Tree"
                    + "\n\r5)  Task 1.5  - Sum of Numbers"
                    + "\n\r6)  Task 1.6  - Font Adjustment"
                    + "\n\rC# LANGUAGE:"
                    + "\n\r7)  Task 1.7  - Array Processing"
                    + "\n\r8)  Task 1.8  - No Positive"
                    + "\n\r9)  Task 1.9  - Non Negative Sum"
                    + "\n\r10) Task 1.10 - 2D Array"
                    + "\n\rC# STRINGS:"
                    + "\n\r11) Task 1.11 - Average String Length"
                    + "\n\r12) Task 1.12 - Char Doubler"
                    + "\n\rEnter 0 for exit\n\r");
            do
            {                
                c = OtherClasses.InputFromConsole.IsInteger(true,true);
                Console.WriteLine("\n\r");

                switch (c)
                {
                    case 1:
                        task1_1.Program.Main();
                        break;
                    case 2:
                        task1_2.Program.Main();
                        break;

                    case 3:
                        break;
                };                
            } while (c != 0);
            Console.ReadKey();
        }
    }
}