using System;

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

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
        }
    }
}