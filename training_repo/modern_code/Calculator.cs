using System;
using Microsoft.Extensions.Logging;

namespace ModernApp
{
    /// <summary>
    /// A modernised calculator using concise syntax and dependency injection for logging.
    /// </summary>
    public class Calculator
    {
        private readonly ILogger<Calculator> _logger;

        public Calculator(ILogger<Calculator> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Performs the requested arithmetic operation on two operands.
        /// Utilises a switch expression and expression‑bodied members for clarity.
        /// </summary>
        public double Calculate(string operation, double a, double b) => operation?.ToLower() switch
        {
            "add"       => LogAndReturn(a + b, a, "+", b),
            "subtract"  => LogAndReturn(a - b, a, "-", b),
            "multiply"  => LogAndReturn(a * b, a, "*", b),
            "divide"    => b == 0 ? throw new DivideByZeroException("Divide by zero not allowed.") : LogAndReturn(a / b, a, "/", b),
            _            => throw new ArgumentException($"Unknown operation '{operation}'.")
        };

        private double LogAndReturn(double result, double a, string op, double b)
        {
            _logger.LogInformation("{Time}: {A} {Operation} {B} = {Result}", DateTimeOffset.Now, a, op, b, result);
            return result;
        }
    }
}