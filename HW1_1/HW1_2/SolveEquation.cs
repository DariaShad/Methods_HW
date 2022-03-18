using System;
using System.Collections.Generic;
using System.Text;

namespace HW1_1
{
    public class SolveEquation
    {
        public double SolveTheEquation(double firstNumber, double secondNumber)
        {
            double difference = secondNumber - firstNumber;
            if(difference==0)
            {
                throw new Exception("The difference between the second and first number must not be zero");
            }
            double result = (5 * firstNumber + secondNumber * secondNumber) / (secondNumber - firstNumber);
            return result;
        }
    }
}
