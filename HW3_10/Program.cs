using System;

namespace HW3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, 
            //например, задано число 123, вывести 321.

            int inputNumber = Convert.ToInt32(Console.ReadLine());
            string outputNumber = "";
            int tmp;
            while (inputNumber > 0)
            {
                tmp = inputNumber % 10;
                outputNumber += tmp.ToString();
                inputNumber = inputNumber / 10;

            }
            Console.WriteLine(outputNumber);






            //string InputNumber =Console.ReadLine();
            //string OutputNumber = "";
            //for (int i=InputNumber.Length-1; i>=0; i--)
            //{
            //    OutputNumber += InputNumber[i];
            //}
            //Console.WriteLine(OutputNumber);
        }

    }
}
    

