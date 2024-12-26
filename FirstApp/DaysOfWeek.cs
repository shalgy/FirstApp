using Microsoft.VisualBasic;
using System;
namespace FirstApp
{
    class MainClass
    {
        public object LovelyDayOfWeek(byte myDay)
        {
            //DaysOfWeek MyFavoriteDay;

            //MyFavoriteDay = DaysOfWeek.Friday;
            return (DaysOfWeek)myDay;
            //Console.WriteLine(CurrentDay);
        }
    }

    enum DaysOfWeek : byte
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
}