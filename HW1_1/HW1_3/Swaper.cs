using System;
using System.Collections.Generic;
using System.Text;

namespace HW1.HW1_3
{
    public class Swaper
    {
        public void Swap(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }
    }
}
