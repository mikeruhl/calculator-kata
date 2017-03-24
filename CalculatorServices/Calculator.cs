namespace CalculatorServices
{
    public class Calculator
    {
        public int Add(string value)
        {
            if (value == string.Empty)
                return 0;
            
            var values = value.Split(',');
            
            int sum = 0;
            foreach(var numberText in values)
            {
                sum +=int.Parse(numberText);
            }

            return sum;
        }
    }
}
