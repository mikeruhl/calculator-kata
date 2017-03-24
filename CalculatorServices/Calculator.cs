using System;
using System.Collections.Generic;

namespace CalculatorServices
{
    public class Calculator
    {
        public int Add(string value)
        {
            if (value == string.Empty)
                return 0;
            
            var delimiters = new List<char>() {',', '\n'};
            if (value.StartsWith("//"))
            {
                delimiters.Add(value[2]);
                value = value.Substring(4);
            }

            var values = value.Split(delimiters.ToArray());
            
            int sum = 0;
            foreach(var numberText in values)
            {
                sum +=int.Parse(numberText);
            }

            return sum;
        }
    }
}
