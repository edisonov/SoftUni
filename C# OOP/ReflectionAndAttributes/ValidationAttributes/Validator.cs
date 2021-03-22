using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] propartis = obj.GetType().GetProperties();

            foreach (var proparty in propartis)
            {
               MyValidationAttribute[] attributes = proparty.GetCustomAttributes()
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                var value = proparty.GetValue(obj);

                foreach (var attribute in attributes)
                {
                    bool isValid = attribute.IsValid(value);

                    if (!isValid)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
