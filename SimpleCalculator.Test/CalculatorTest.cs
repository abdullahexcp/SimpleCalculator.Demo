using NUnit.Framework;
using SimpleCalculator.Demo;
using System;

namespace SimpleCalculator.Test
{
    [TestFixture]
    public class CalculatorTest
    {

        [Test, Order(1)]
        public void TestAdd_TwoDoubleNumbers_ReturnsSum()
        {
            var result = CreateNewCalculatorInstance().Addition(3.1, 5.8);
            Assert.AreEqual(8.9, result);
        }

        [TestCase(1, 2, 3), Order(2)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 4, 7)]
        public void MultipleTest_Addition_ReturnsSum(double first, double second, double expectedresult)
        {
            var calculated = CreateNewCalculatorInstance().Addition(first, second);
            Assert.AreEqual(expectedresult, calculated);
        }

        //[Ignore("Ignore test")]
        [Test, Order(3)]
        public void TestSubtract_ArgumentException()
        {
            Assert.Catch<SystemException>(() => CreateNewCalculatorInstance().Subtraction(4, 6));
            Assert.Throws<ArgumentException>(() => CreateNewCalculatorInstance().Subtraction(4, 6));
        }

        [TestCase(10, 2, 8), Order(4)]
        [TestCase(10, -3, 13)]
        public void MultipleTest_Subtraction_Of_DoubleNumbers(double first, double second, double expectedresult)
        {
            var calculated = CreateNewCalculatorInstance().Subtraction(first, second);
            Assert.AreEqual(expectedresult, calculated);
        }

        [TestCase(10, -15, -150), Order(5)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 4, 0)]
        public void MultipleTest_Multiplication_Of_DoubleNumbers(double first, double second, double expectedresult)
        {
            var calculated = CreateNewCalculatorInstance().Multiplication(first, second);
            Assert.AreEqual(expectedresult, calculated);
        }


        [Test, Order(6)]
        public void Test_DivisionByZero_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CreateNewCalculatorInstance().Division(4, 0));
        }

        [TestCase(10, -5, -2), Order(7)]
        [TestCase(1.5, 10, 0.15)]
        [TestCase(0, 4, 0)]
        public void MultipleTest_Division_Of_DoubleNumbers(double first, double second, double expectedresult)
        {
            var calculated = CreateNewCalculatorInstance().Division(first, second);
            Assert.AreEqual(expectedresult, calculated);
        }

        //helper methods
        private Calculator CreateNewCalculatorInstance()
        {
            return new Calculator();
        }

    }
}
