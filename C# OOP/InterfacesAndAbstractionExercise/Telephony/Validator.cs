using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public static class Validator
    {
        public static void ThrowIfNumberIsInvalid(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }
        }
    }
}
