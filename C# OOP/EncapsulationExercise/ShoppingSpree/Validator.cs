using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new AggregateException(exceptionMessage);
            }
        }

        public static void ThrowIsNumberIsNegative(decimal number, string exceptionMessage)
        {
            if (number < 0)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
