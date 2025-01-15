using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример работы с кортежем
            //(string name, int age) anketa;
            //Console.Write("Введите имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите возраст с цифрами: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //Console.ReadKey();

            //Задание 4.4.3
            //var (name, age) = ("Алексей", 46);

            //Console.WriteLine("Мое имя: {0}", name);
            //Console.WriteLine("Мой возраст: {0}", age);

            //Console.Write("Введите имя: ");
            //name = Console.ReadLine();
            //Console.Write("Введите возраст с цифрами: ");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            //Console.ReadKey();

            //Задание 4.4.5 Кортежи
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("Введите имя Вашего питомца: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Введите тип Вашего питомца (кошка, собака, хомяк и т.п.): ");
            Pet.Type = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("Кличка Вашего питомца: {0}\nТип: {1}\nВозраст: {2} года\nДлина имени: {3} символа", Pet.Name, Pet.Type, Pet.Age, Pet.NameCount);

        }
    }
}