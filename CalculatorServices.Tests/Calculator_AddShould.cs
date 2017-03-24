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
    }
}
