using System;

namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            int A = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= A; i++)
            {
                if (i * i < A)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
