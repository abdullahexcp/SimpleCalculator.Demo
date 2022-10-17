using System;

namespace SimpleCalculator.Demo
{
    public class Calculator
    {
        public double Addition(double first, double second)
        {
            return first + second;
        }

        public double Subtraction(double first, double second)
        {
            if (first < second)
                throw new ArgumentException($"First number {first} is less than second number {second}");

            return first - second;
        }

        public double Multiplication(double first, double second)
        {
            return first * second;
        }

        public double Division(double first, double second)
        {
            if (second == 0)
            {
                throw new ArgumentException($"Math Error, Can't divide by {second} as a second number");
            }
            else
            {
                return first / second;
            }
        }
    }
}
