using System;

namespace HW3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            int A = Convert.ToInt32(Console.ReadLine());
            int number = 0;
            int count = 0;

            while (A > 0)
            {
                number = A % 10;
                A = A / 10;
                if (number % 2 == 1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}

