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
    }
}
