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

            value = ParseDelimiters(value);
            var values = ParseValues(value);
            int sum = SumValues(values);

            return sum;
        }

        private string ParseDelimiters(string value)
        {
            if (value.StartsWith("//"))
            {
                delimiters.Add(value[2]);
                value = value.Substring(4);
            }

            return value;
        }

        private string[] ParseValues(string value)
        {
            return value.Split(delimiters.ToArray());
        }

        private static int SumValues(string[] values)
        {
            int sum = 0;
            foreach (var numberText in values)
            {
                var number = int.Parse(numberText);
                HandleNegatives(number);
                sum += number;
            }

            return sum;
        }

        private static void HandleNegatives(int number)
        {
            if (number < 0)
                throw new ArgumentException("Negatives not allowed");
        }
    }
}
