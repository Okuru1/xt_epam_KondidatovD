using System;
using OtherClasses;


namespace task2_5
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 2.5 for XT_EPAM" + "\n\r--------------------");

            Console.WriteLine(" Enter Name: ");
            //name = Console.ReadLine();
            Console.WriteLine(" Enter Surname: ");
            //surname = Console.ReadLine();
            Console.WriteLine(" Enter Patronymic: ");
            //patronymic = Console.ReadLine();
            Console.WriteLine(" Enter Date of Birth: ");
            //dateOfBirth = Console.ReadLine();
            Console.WriteLine(" Enter Age: ");
            //age = InputFromConsole.IsInteger();

            User first = new User("name", "surname", "patronymic", 15, "14.123.12321");
            Employee me = new Employee(first, "sdadsa", 23);

            first.GetInfo();
            //Console.WriteLine("\n\r");
            me.GetInfo();
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
        public User(string Name, string Surname, int Age) : this(Name, Surname, Age, "???")
        {
        }
        public User(string Name, string Surname, int Age, string DateOfBirth) : this(Name, Surname, "???", Age, DateOfBirth)
        {
        }
        public User(string Name, string Patronymic, string Surname, int Age, string DateOfBirth)
        {
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Surname = Surname;
            this.Age = Age;
            this.DateOfBirth = DateOfBirth;
        }

        public void GetInfo()
        {
            Console.WriteLine("\n\r Name: " + Name + "\n\r Patronymic: " + Patronymic + "\n\r Surname: " + Surname + "\n\r Age: " + Age + "\n\r Date of Birth: " + DateOfBirth);
        }
    }

    class Employee : User
    {
        public string Position;
        public int Experience;

        public Employee(User user, string Position, int Experience)
        {
            Name = user.Name;
            Patronymic = user.Patronymic;
            Surname = user.Surname;
            Age = user.Age;
            DateOfBirth = user.DateOfBirth; 

            this.Position = Position;
            this.Experience = Experience;
        }
        public new void GetInfo()
        {
            Console.WriteLine("\n\r Name: " + Name 
                + "\n\r Patronymic: " + Patronymic 
                + "\n\r Surname: " + Surname 
                + "\n\r Age: " + Age 
                + "\n\r Date of Birth: " + DateOfBirth 
                + "\n\r Position: " + Position
                + "\n\r Experience: " + Experience);
        }

    }
}
