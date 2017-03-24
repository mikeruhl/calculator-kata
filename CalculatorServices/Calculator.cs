namespace CalculatorServices
{
    public class Calculator
    {
        public int Add(string value)
        {
            if (value == string.Empty)
                return 0;

            return int.Parse(value);
        }
    }
}
