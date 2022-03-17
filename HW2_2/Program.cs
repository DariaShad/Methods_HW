using System;

namespace HW2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DefineQuarter(X, Y));
        }

        static string DefineQuarter(int X, int Y)
        {
            if (X > 0 || Y > 0)
            {
                return "Четверть I";
            }

            if (X < 0 || Y > 0)
            {
                return "Четверть II";
            }

            if (X < 0 || Y < 0)
            {
                return "Четверть III";
            }

            if (X > 0 || Y < 0)
            {
                return "Четверть IV";
            }

            else
            {
                throw new Exception("Введите значения больше нуля");
            }

        }
    }
}
