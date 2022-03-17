using HW1_1;
using NUnit.Framework;

namespace HW1.Tests
{
    public class HW1_1Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [TestCase(4,2,2)]
        public void Divide_TrueTest(int divisible, int divisor, double expected)
        {
            Divider divider=new Divider();//создаем объект класса девайдер
            double actual=divider.Divide(divisible, divisor);
            Assert.AreEqual(expected, actual);
        }
    }
}