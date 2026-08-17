using System;

namespace DemoCalculator
{
    /// <summary>
    /// A simple calculator class that performs basic arithmetic operations.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The sum of a and b</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The difference of a and b</returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The product of a and b</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="a">Dividend</param>
        /// <param name="b">Divisor</param>
        /// <returns>The quotient of a and b</returns>
        /// <exception cref="ArgumentException">Thrown when b is zero</exception>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.", nameof(b));
            }
            return a / b;
        }

        /// <summary>
        /// Calculates the remainder of division.
        /// </summary>
        /// <param name="a">Dividend</param>
        /// <param name="b">Divisor</param>
        /// <returns>The remainder of a divided by b</returns>
        /// <exception cref="ArgumentException">Thrown when b is zero</exception>
        public static double Modulo(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.", nameof(b));
            }
            return a % b;
        }
    }
}
