using System;

namespace Leybold.Common
{
    /// <summary>
    /// A class which implements some basic algebra.
    /// </summary>
    public static class Mathematics
    {
        /// <summary>
        /// Calculate the sum of two given numbers.
        /// </summary>
        /// <param name="l">First operand of sum operation.</param>
        /// <param name="r">Second operand of sum operation.</param>
        /// <returns>The sum of both operands.</returns>
        public static double Sum(double l, double r)
        {
            return l + r;
        }

        /// <summary>
        /// Calculate the substraction of two given numbers.
        /// </summary>
        /// <param name="minuend">The minued of the substraction.</param>
        /// <param name="subtrahend">The subtrahend of the substraction.</param>
        /// <returns>The difference.</returns>
        public static double Diff(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }
    }
}
