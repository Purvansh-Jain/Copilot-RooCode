using System;
using System.IO;

namespace LegacyApp
{
    /// <summary>
    /// Simple calculator implemented in an older style.
    /// </summary>
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        /// <summary>
        /// Performs an operation based on the operation name. This method uses simple if‑else
        /// statements and writes logs to a file manually, typical of older code bases.
        /// </summary>
        public double Calculate(string operation, double a, double b)
        {
            double result;
            if (operation == "add")
            {
                result = Add(a, b);
            }
            else if (operation == "subtract")
            {
                result = Subtract(a, b);
            }
            else if (operation == "multiply")
            {
                result = Multiply(a, b);
            }
            else if (operation == "divide")
            {
                result = Divide(a, b);
            }
            else
            {
                throw new ArgumentException("Invalid operation.");
            }

            // rudimentary logging
            File.AppendAllText("calculator.log", string.Format("{0}: {1} {2} {3} = {4}\n", DateTime.Now, a, operation, b, result));
            return result;
        }
    }
}