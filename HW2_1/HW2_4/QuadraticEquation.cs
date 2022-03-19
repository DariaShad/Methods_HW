using System;

namespace HW2_4
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X) 
            //квадратного уравнения стандартного вида, где AX2 + BX + C = 0.
            double A = Convert.ToInt32(Console.ReadLine());
            double B = Convert.ToInt32(Console.ReadLine());
            double C = Convert.ToInt32(Console.ReadLine());

            double D = (B * B) - 4 * A * C;
            if (D < 0)
            {
                Console.WriteLine("Корней нет");
            }
            if (D == 0)
            {
                Console.WriteLine("Есть один корень");
            }


            if (D > 0)
            {
                Console.WriteLine("Есть два корня");
                double X1 = (-B + Math.Sqrt(D)) / (2 * A);
                double X2 = (-B - Math.Sqrt(D)) / (2 * A);

                Console.WriteLine(X1);
                Console.WriteLine(X2);
            }

        }
    }
}
