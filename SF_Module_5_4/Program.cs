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

        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();
            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());
            deep = deep <= 15 ? deep : 15; //15 максимальное значение для перечисления
            Echo(str, deep);
            Console.ReadKey();
        }
        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
            Console.ResetColor();
        }
    }
}