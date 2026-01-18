using System;
using static System.Console;

namespace Module4
{
    class MainClass
    {
        private static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
            Console.WriteLine("Введите имя");
            User.Name = ReadLine();
            WriteLine("Введите фамилию");
            User.LastName = ReadLine();
            WriteLine("Введите логин");
            User.Login = ReadLine();
        }
    }
}