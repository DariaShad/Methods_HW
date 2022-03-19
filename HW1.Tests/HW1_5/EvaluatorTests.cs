using HW1.HW1_5;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW1.Tests.HW1_5
{
    public class EvaluatorTests
    {
        //Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. 
        //Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.
        [TestCase(20, 30, 19, 22, "Y=8X+-130")]
        public void Evaluator_Tests(double X1, double Y1, double X2, double Y2, string expected)
        {
            Evalutor evaluator = new Evalutor();
            string actual = evaluator.GetEquation(X1, Y1, X2, Y2);
            Assert.AreEqual(expected, actual);
        }
    }
}
