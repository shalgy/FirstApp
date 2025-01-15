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

            //Вывод имени по буквам и в обратном порядке
            //Console.WriteLine("Введите Ваше имя:");
            //string myname = Console.ReadLine();
            //Console.WriteLine("Ваше имя по буквам: ");
            //foreach (var chr in myname) {
            //    Console.Write(chr + " ");
            //}
            //Console.WriteLine("Последняя буква вашего имени: {0}", myname[myname.Length - 1] );
            //Console.WriteLine("Ваше имя в обратном порядке");
            //int i = 0;
            //for (i = myname.Length - 1; i != 0; i-- )
            //{
            //    Console.Write(myname[i]);
            //}
            //Console.WriteLine(myname[i]);
            //Console.ReadKey();

            //Сортировка массива (не выполнил самостоятельно смотрел подсказку)
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //int temp;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}

            //Суммирование всех элементов массива
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            //int val = 0;
            //for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            //{
            //    val += arr[i];
            //}
            //Console.WriteLine(val);

            //Вывод в строку всех элементов массива массивов
            //int[][] array = new int[3][];
            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };

            //foreach (var aritem in array)
            //{
            //    foreach (var item in aritem)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}

            //Задание 4.3.15 на суммирование всех положительных чисел в массиве
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4, -3, -8, 15, 12 ,-1, 51 };
            //int val = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] >= 0) { val += arr[i]; }
            //}
            //Console.WriteLine("Сумма положительных чисел в массиве равна: {0}",val);

            //Задание 4.3.16
            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //int sum = 0;
            //foreach (int i in arr)
            //{
            //    if (i >= 0) { sum += i; }
            //}
            //Console.WriteLine("Сумма положительных чисел в массиве равна: {0}", sum);

            //Задание 4.3.17
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp;

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }


            //Console.WriteLine("Количество элементов {0} измерения массива = {1}, наибольший индекс измерения {0} = {2}", k, arr.GetLength(k), arr.GetUpperBound(k));
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                { 
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }

        }
    }
}