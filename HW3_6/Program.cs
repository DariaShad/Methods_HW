using System;

namespace HW3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи. 
            //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
            // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233

            //int N = Convert.ToInt32(Console.ReadLine());
            int lastFirst = 1;
            int lastSecond = 1;
            int result = 0;
            int countOfNumbers = Convert.ToInt32(Console.ReadLine());


            for (int i = 3; i <= countOfNumbers; i++)
            {
                result = lastFirst + lastSecond;
                lastFirst = lastSecond;
                lastSecond = result;

            }

            Console.WriteLine(result);
        }
    }
}
