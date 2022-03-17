using System;

namespace HW1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.

            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Divide(A, B));
            Console.WriteLine(CalculateTheRemainder(A, B));
        }

        static double Divide(double divisible, double divisor)
        {
            double result = divisible / divisor;
            return result;
        }

        static double CalculateTheRemainder(double divisible, double divisor)
        {
            double remainder = divisible % divisor;
            return remainder;
        }
    }
}
