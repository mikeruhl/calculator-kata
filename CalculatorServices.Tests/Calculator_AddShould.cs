using System;
using Xunit;

namespace CalculatorServices.Tests
{
    public class Calculator_AddShould
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            var calculator = new Calculator();
            int result = calculator.Add("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_SingleNumber_ReturnsThatNumber()
        {
            var calculator = new Calculator();
            int result = calculator.Add("1");
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(3, "1,2")]
        [InlineData(10, "1,2,3,4")]
        public void Add_MultipleNumbers_ReturnsSum(int expected, string value)
        {
            var calculator = new Calculator();
            int result = calculator.Add(value);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_NewLineDelimiter_ReturnsSum()
        {
            var calculator = new Calculator();
            int result = calculator.Add("1\n2\n3");
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_CustomDelimiter_ReturnsSum()
        {
            var calculator = new Calculator();
            int result = calculator.Add("//;\n2;3");
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_NegativeNumber_ThrowsException()
        {
            var calculator = new Calculator();
            var exception = Record.Exception(
                () => calculator.Add("-1")
            );
            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
            Assert.Equal("Negatives not allowed", exception.Message);
        }
    }
}
