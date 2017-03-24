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
    }
}
