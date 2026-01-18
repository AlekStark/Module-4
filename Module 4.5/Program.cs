using System;
using static System.Console;

namespace Module4
{
    class MainClass
    {
        private static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
            for (int k = 0; k < 3; k++)
            {
                WriteLine("Введите имя");
                User.Name = ReadLine();
                WriteLine("Введите фамилию");
                User.LastName = ReadLine();
                WriteLine("Введите логин");
                User.Login = ReadLine();
                User.LoginLength = User.Login.Length;
                WriteLine("Есть ли у вас животные? Да или Нет");
                var result = ReadLine();
                if (result == "Y")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }
                WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(ReadLine());
                User.favcolors = new string[3];
                WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = ReadLine();
                }
            }
        }
    }
}