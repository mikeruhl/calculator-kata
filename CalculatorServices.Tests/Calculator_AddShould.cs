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

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var calculator = new Calculator();
            int result = calculator.Add("1,2");
            Assert.Equal(3, result);
        }
    }
}
