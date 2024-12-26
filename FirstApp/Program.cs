using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Alexey";
            const byte MyAge = 46;
            const bool IsHavePet = true;
            const double ShoeSize = 43.5;
            MainClass LovelyDay = new MainClass();
            //const float ShoeSize = 43.5f; или так чтобы программа ела чуть меньше памяти
            Console.WriteLine("My name is {0}\n"+
                              "My age is {1}\n"+
                              "Do I have a pet? {2}\n" +
                              "My shoe size is {3}\n"+
                              "My lovely day is {4}",
                              MyName, MyAge, IsHavePet, ShoeSize, LovelyDay.LovelyDayOfWeek(5));
            LovelyDay = null; 
            Console.ReadKey();
        }
    }
}