using System;
using OtherClasses;

namespace task2_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 2.3 for XT_EPAM" + "\n\r--------------------");
            string name, surname, patronymic, dateOfBirth;
            int age;
            Console.WriteLine(" Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine(" Enter Surname: ");
            surname = Console.ReadLine();
            Console.WriteLine(" Enter Patronymic: ");
            patronymic = Console.ReadLine();
            Console.WriteLine(" Enter Date of Birth: ");
            dateOfBirth = Console.ReadLine();
            Console.WriteLine(" Enter Age: ");
            age = InputFromConsole.IsInteger();

            User first = new User(name, patronymic, surname, age, dateOfBirth);

            first.GetInfo();
        }
    }

    class User
    {
        public string Name;
        public string Patronymic;
        public string Surname;
        public string DateOfBirth;
        public int Age;

        public User() : this("???")
        {
        }
        public User(string Name) : this(Name, "???")
        {
        }
        public User(string Name, string Surname) : this(Name, Surname, 0)
        { 
        }
        public User(string Name, string Surname, int Age) : this (Name, Surname, Age, "???")
        {           
        }
        public User(string Name, string Surname, int Age, string DateOfBirth) : this (Name, Surname, "???", Age, DateOfBirth)
        {
        }
        public User(string Name, string Patronymic, string Surname, int Age, string DateOfBirth)
        {
            this.Name=Name;
            this.Patronymic=Patronymic;
            this.Surname=Surname;
            this.Age=Age;
            this.DateOfBirth=DateOfBirth;
        }

        public void GetInfo()
        {
            Console.WriteLine(" Name: "+ Name+"\n\r Patronymic: "+Patronymic+"\n\r Surname: "+Surname+"\n\r Age: "+Age+"\n\r Date of Birth: "+DateOfBirth);
        }
    }
}
