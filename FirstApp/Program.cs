using System;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Модуль 5. Задание 1
            // Создайте кортеж User, содержащий имя пользователя Name и массив с текстовой информацией о его пяти любимых блюдах Dishes.
            // Заполните имя пользователя через ввод в консоль, а информацию о блюдах — в цикле через консоль.
        (string Name, string[] Dishes) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Укажите пять любимых блюд, например: жаркое из баранины, нажмимайте Enter после ввода каждого блюда");
            User.Dishes = new string[5];
             for (int i = 0; i < User.Dishes.Length; i++)
                { 
                    User.Dishes[i] = Console.ReadLine();
                }
        }
    }
}