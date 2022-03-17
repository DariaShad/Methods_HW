using System;

namespace HW2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 3 числа(A, B и С).Выведите их в консоль в порядке возрастания.

            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int[] massive = new int[3] { A, B, C };

            if (A > B || A > C)
            {
                if (B > C)
                {
                    string ABC = $"{A}" + $"{B}" + $"{C}";
                    Console.WriteLine(ABC);
                }
                if (C > B)
                {
                    string ACB = $"{A}" + $"{C}" + $"{B}";
                    Console.WriteLine(ACB);
                }
            }

            if (B > C || B > A)
            {
                if (C > A)
                {
                    string BCA = $"{B}" + $"{C}" + $"{A}";
                    Console.WriteLine(BCA);
                }
                else
                {
                    string BAC = $"{B}" + $"{A}" + $"{C}";
                    Console.WriteLine(BAC);
                }
            }

            else
            {
                if (A > B)
                {
                    string CAB = $"{C}" + $"{A}" + $"{B}";
                    Console.WriteLine(CAB);
                }
                else
                {
                    string CBA = $"{C}" + $"{B}" + $"{A}";
                    Console.WriteLine(CBA);
                }
            }

        }
    }
}

