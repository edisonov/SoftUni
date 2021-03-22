namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;
        private readonly bool inclusiv;

        public MyRangeAttribute(int minValue, int maxValue, bool inclusiv = true)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.inclusiv = inclusiv;
        }

        public override bool IsValid(object obj)
        {
            int number = (int)obj;

            if (inclusiv)
            {
                return number >= this.minValue && number <= this.maxValue;
            }

            return number > this.minValue && number < this.maxValue;
        }
    }
}
