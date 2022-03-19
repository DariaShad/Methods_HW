using System;

namespace HW2_1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateDependingOnValues(A, B));
        }
        static int CalculateDependingOnValues(int first, int second)
        {
            if (first > second)
            {
                return first + second;
            }

            if (first == second)
            {
                return first * second;
            }

            else
            {
                return first - second;
            }
        }
    }
}
