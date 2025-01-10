using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string MyName = "Alexey";
            //const byte MyAge = 46;
            //const bool IsHavePet = true;
            //const double ShoeSize = 43.5;
            //MainClass LovelyDay = new MainClass();
            //const float ShoeSize = 43.5f; или так чтобы программа ела чуть меньше памяти
            //Console.WriteLine("My name is {0}\n"+
            //                  "My age is {1}\n"+
            //                  "Do I have a pet? {2}\n" +
            //                  "My shoe size is {3}\n"+
            //                  "My lovely day is {4}",
            //                  MyName, MyAge, IsHavePet, ShoeSize, LovelyDay.LovelyDayOfWeek(5));
            //Console.WriteLine("{0}\n {1}\n {2}\n", MyName, MyAge, ShoeSize);
            //string str = Console.ReadLine();
            //LovelyDay = null;
            //Console.WriteLine("Цикл While");
            //int k = 0;
            //while (true)
            //{
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //    Console.WriteLine(k);
            //    var text = Console.ReadLine();

            //    switch (text)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }

            //    if (text == "stop")
            //    {
            //        Console.WriteLine("Цикл остановлен");
            //        break;
            //    }
            //    k++;
            //}

            //Console.WriteLine("Цикл do");
            //int t = 0;
            //do
            //{
            //    Console.WriteLine(t);
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }
            //    t++;
            //} while (t < 2);
            Console.WriteLine("Введите Ваше имя:");
            string myname = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам: ");
            foreach (var chr in myname) {
                Console.Write(chr + " ");
            }
            Console.WriteLine("Последняя буква вашего имени: {0}", myname[myname.Length - 1] );
            Console.WriteLine("Ваше имя в обратном порядке");
            int i = 0;
            for (i = myname.Length - 1; i != 0; i-- )
            {
                Console.Write(myname[i]);
            }
            Console.WriteLine(myname[i]);
            Console.ReadKey();
        }
    }
}