using System;

namespace HW3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int a = A;

            for (int i = 0; i < B; i++)
            {
                Console.WriteLine(a);
                a = A * a;
            }


        }
    }
}
