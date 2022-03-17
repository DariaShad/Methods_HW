using System;

namespace HW3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число(A).Вывести наибольший делитель(кроме самого A) числа A.
            int A = Convert.ToInt32(Console.ReadLine());
            int divider = 0;
            for (int i = 1; i < A; i++)
            {
                if (A % i == 0)
                {
                    divider = i;
                }
            }

            Console.WriteLine(divider);

        }
    }
}
