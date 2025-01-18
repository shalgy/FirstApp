using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SF_Module_5_4
{
    class Program
    {
        //Задание 5.5.8 Необходимо написать рекурсивный метод, который возводит введенное число N типа int в указанную степень pow типа byte.
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите число для возведения в степень:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите степень, для возведения в нее числа {0}:", N);
            byte pow = byte.Parse(Console.ReadLine());
            Console.WriteLine("Число {0} возведенное в степень {1} равно: {2}", N, pow, Exponentiation(N, ref pow));
            Console.ReadKey();
        }

        static int Exponentiation(int N, ref byte pow)
        {
            if (pow == 1) { return N; }
            else
            {
                pow--;
                return N + Exponentiation(N, ref pow);
            }
        }

        //Задание 5.5.7 Вычисление факториала числа

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Укажите число для подсчета факториала");
        //    var x = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Факториал для числа {0} равен: {1}",x ,Factorial(x));
        //    Console.ReadKey();
        //}
        //static decimal Factorial(int x)
        //{
        //    if (x == 0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return x * Factorial(x - 1);
        //    }
        //}

        //Задание 5.5.4 Пример использования рекурсивной функции, создание программы Эхо

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Напишите что-то");
        //    var str = Console.ReadLine();
        //    Console.WriteLine("Укажите глубину эха");
        //    var deep = int.Parse(Console.ReadLine());
        //    deep = deep <= 15 ? deep : 15; //15 максимальное значение для перечисления
        //    Echo(str, deep);
        //    Console.ReadKey();
        //}
        //static void Echo(string saidworld, int deep)
        //{
        //    var modif = saidworld;
        //    if (modif.Length > 2)
        //    {
        //        modif = modif.Remove(0, 2);
        //    }

        //    Console.BackgroundColor = (ConsoleColor)deep;
        //    Console.WriteLine("..." + modif);

        //    if (deep > 1)
        //    {
        //        Echo(modif, deep - 1);
        //    }
        //    Console.ResetColor();
        //}
    }
}