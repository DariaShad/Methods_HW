using HW1_1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW1.Tests.HW1_2
{
    public class SolveEquationTest
    {
        //Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B^2)/(B-A)
        [TestCase(2, 3, 19)]
        [TestCase(2, 0, -5)]
        [TestCase(-2, -4, -3)] 
        public void SolveEquation_Test(double firstNumber, double secondNumber, double expected)
        {
            SolveEquation solveEquation= new SolveEquation();
            double actual = solveEquation.SolveTheEquation(firstNumber, secondNumber);
            Assert.AreEqual(expected, actual);   
        }
    }

}

