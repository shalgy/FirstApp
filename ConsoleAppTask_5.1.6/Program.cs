using System;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppTask_5._1._6
{

    class Program
    {

        //public static void Main(string[] args)
        //{

        //    var arr = new int[] { 1, 2, 3 };
        //    BigDataOperation(arr);

        //    Console.WriteLine(arr[0]);

        //}

        //static void BigDataOperation(in int[] arr)
        //{
        //    arr[0] = 4;
        //}

        //static void Main(string[] args)
        //{
        //    double Age=40;
        //    ChangeAge(ref Age);
        //    Console.WriteLine("Ваш возраст: {0}",Age.ToString());
        //    Console.ReadKey();
        //}
        //static double ChangeAge(ref double Age)
        //{
        //    Console.WriteLine("Введите Ваш возраст:");
        //    Age = Convert.ToDouble(Console.ReadLine());
        //    return Age;
        //}

        //Задание 5.3.8
        //static int[] GetArrayFromConsole(ref int num)
        //{
        //    var result = new int[num];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        //        result[i] = int.Parse(Console.ReadLine());
        //    }

        //    return result;
        //}
        //static int[] SortArray(int[] arrayforsort)
        //{
        //    var result = arrayforsort;
        //    int temp;
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        for (int j = i + 1; j < result.Length; j++)
        //        {
        //            if (result[i] > result[j])
        //            {
        //                temp = result[i];
        //                result[i] = result[j];
        //                result[j] = temp;
        //            }
        //        }
        //    }
        //    return result;
        //}
        static void Main(string[] args)
        {
            //var array = new int[0];
            //int num = 6;
            //array = GetArrayFromConsole(ref num);
            //int[] sortedarray = SortArray(array);
            //ShowArray(sortedarray, true);
            //Console.ReadKey();
            int num1 = 2;
            int num2 = 5;
            int num3=10;
            int num4 = 15;
            Console.WriteLine(SumNumbers(ref num1, num2, out num3, num4));

        }
        static int SumNumbers(ref int num1, in int num2, out int num3, int num4)
        {
            num1 = 7;
            num3 = num1 + num2;
            return (num1 + num2 + num3 + num4) * num4;
        }

        //static void ShowArray(int[] array, bool Sorting = false)
        //{
        //    int[] temp = array;
        //    if (Sorting)
        //    {
        //        temp = SortArray(array);
        //    }
        //    foreach (var item in temp)
        //    {
        //        Console.Write(item + " ");
        //    }
        //}

        //static void SortComplexArray(int[,] arr)
        //{
        //    int temp;
        //    for (int i = 0; i <= arr.GetUpperBound(0); i++)
        //    {
        //        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        //            for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
        //                if (arr[i, j] > arr[i, k])
        //                {
        //                    temp = arr[i, k];
        //                    arr[i, k] = arr[i, j];
        //                    arr[i, j] = temp;
        //                }
        //    }
        //}
        //static void Main(string[] args)
        //{

        //    int[,] arr = {
        //                    { - 5,
        //                      6,
        //                      9,
        //                      1,
        //                      2,
        //                      -3
        //                    },
        //                    { - 8,
        //                      8,
        //                      1,
        //                      1,
        //                      2,
        //                      -3
        //                    }
        //                  };

        //    SortComplexArray(arr);

        //}
    }
}