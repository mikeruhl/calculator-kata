using System;
using System.Collections.Generic;

namespace CalculatorServices
{
    public class Calculator
    {
        List<char> delimiters = new List<char>() { ',', '\n' };
        public int Add(string value)
        {
            if (value == string.Empty)
                return 0;

            if (value.StartsWith("//"))
            {
                delimiters.Add(value[2]);
                value = value.Substring(4);   
            }
            
            var values = value.Split(delimiters.ToArray());

            int sum = 0;
            foreach (var numberText in values)
            {
                var number = int.Parse(numberText);
                if (number < 0)
                    throw new ArgumentException("Negatives not allowed");
                sum += number;
            }

            return sum;
        }

        private List<char> ParseDelimiters(string value)
        {
            

            return delimiters;
        }
    }
}
