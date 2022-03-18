using System;
using System.Collections.Generic;
using System.Text;

namespace HW1.HW1_5
{
    public class Evalutor
    {
        public void GetEquation(double X1, double Y1, double X2, double Y2)
        {
            Console.WriteLine($"Y={(Y2 - Y1) / (X2 - X1)}X+{-X1 * (Y2 - Y1) / (X2 - X1) + Y1}");
        }
    }
}
