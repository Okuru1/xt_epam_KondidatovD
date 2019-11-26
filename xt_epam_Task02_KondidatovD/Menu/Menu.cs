using System;

//---------Notisfaction--------------
//Из-за очень ограниченного времени (работа + подготовка к сессии), 
//комментариев в программе не так уж много.
//Спасибо за понимание

namespace Menu
{
    class Menu
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("XT_EPAM_2019 TASK-01 C# Basics by Kondidatov Dmitriy"
                    + "\n\rChoose Task: "
                    + "\n\r1)  Task 2.1  - Round"
                    + "\n\r2)  Task 2.2  - Triangle"
                    + "\n\r3)  Task 2.3  - User"
                    + "\n\r4)  Task 2.4  - My String"
                    + "\n\r5)  Task 2.5  - Employee"
                    + "\n\r6)  Task 2.6  - Ring"
                    + "\n\r7)  Task 2.7  - Vector Graphics Editor"
                    + "\n\r8)  Task 2.8  - Game"
                    + "\n\rEnter 0 for exit\n\r");
            do
            {
                c = OtherClasses.InputFromConsole.IsInteger(true, true);
                //Console.WriteLine("\n\r");

                switch (c)
                {
                    case 1:
                        task2_1.Program.Main();
                        break;
                    case 2:
                        task2_2.Program.Main();
                        break;
                    case 3:
                        task2_3.Program.Main();
                        break;
                    //case 4:
                    //    task2_4.Program.Main();
                    //    break;
                    //case 5:
                    //    task2_5.Program.Main();
                    //    break;
                    //case 6:
                    //    task2_6.Program.Main();
                    //    break;
                    //case 7:
                    //    task2_7.Program.Main();
                    //    break;
                    //case 8:
                    //    task2_8.Program.Main();
                    //    break;
                };
                Console.WriteLine("\n\rProgram completed, select next action");
            } while (c != 0);
        }
    }
}