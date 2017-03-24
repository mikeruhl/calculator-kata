namespace CalculatorServices
{
    public class Calculator
    {
        public int Add(string value)
        {
            if (value == string.Empty)
                return 0;
            
            var delimiters = new char[] {',', '\n'};
            var values = value.Split(delimiters);
            
            int sum = 0;
            foreach(var numberText in values)
            {
                sum +=int.Parse(numberText);
            }

            return sum;
        }
    }
}
