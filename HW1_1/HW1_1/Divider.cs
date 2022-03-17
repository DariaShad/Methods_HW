using System;
using System.Collections.Generic;
using System.Text;

namespace HW1_1
{
   public class Divider
    {
        public double Divide(double divisible, double divisor)
        {
            double result = divisible / divisor;
            return result;
        }

        public double CalculateTheRemainder(double divisible, double divisor)
        {
            double remainder = divisible % divisor;
            return remainder;
        }
    }
}
