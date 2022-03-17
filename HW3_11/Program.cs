using System;

namespace HW3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
            int N = Convert.ToInt32(Console.ReadLine());
            int parity = 0;
            int odd = 0;
            int tmp;
            for (int i = 1; i <= N; i++)
            {
                while (i > 0)
                {
                    tmp = i % 10;
                    i = i / 10;
                    if (tmp % 2 == 1)
                    {

                    }
                }
            }
        }
    }
}
