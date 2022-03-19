using HW1.HW1_4;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW1.Tests.HW1_4
{
    class SolverTests

    {
        //Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения 
        //стандартного вида, где A*X+B=C.
        //result = third / first - second
        [TestCase(2, 5, 12, 1)]
        [TestCase(5, 0, 50, 10)]
        public void Solver_Tests(int first, int second, int third, int expected)
        {
            Solver solver = new Solver();
            int actual = solver.SolveTheEquation(first, second, third);
            Assert.AreEqual(expected, actual);
        }
    }
}
