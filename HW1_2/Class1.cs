using System;
using System.Collections.Generic;
using System.Text;

namespace HW1_2
{
    class SolveEquation
    {
        public double SolveTheEquation(double firstNumber, double secondNumber)
        {
            double result = (5 * firstNumber + secondNumber * secondNumber) / (secondNumber - firstNumber);
            return result;
        }
    }
}
