using System;

namespace HW3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. 
            //(Учтите, что при вводе B может оказаться меньше A).
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (B < A)
            {
                Console.WriteLine("Второе число должно быть больше первого!");
            }

            for (int i = A; i <= B; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
