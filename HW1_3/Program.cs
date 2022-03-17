using System;

namespace HW1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте содержимое переменных A и B местами.
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            Swap(ref A, ref B);
            Console.WriteLine(A);
            Console.WriteLine(B);
        }

        static void Swap(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }
    }
}
