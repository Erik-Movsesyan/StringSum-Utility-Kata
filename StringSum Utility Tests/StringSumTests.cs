using FluentAssertions;
using StringSum_Utility_Kata;

namespace StringSum_Utility_Tests
{
    public class StringSumTests
    {
        [TestCase("1","2","3")]
        [TestCase("100","200","300")]
        [TestCase("4443","2","4445")]
        public void Sum_WithTwoNaturalParams_ReturnsTheCorrectSummedResult(string num1, string num2, string expectedResult)
        {
            //Arrange
            var utility = new StringSum();

            //Act
            var actualResult = utility.Sum(num1, num2);

            //Assert
            actualResult.Should().Be(expectedResult);
        }

        [TestCase("-1", "2")]
        [TestCase("2", "-1")]
        [TestCase("-2", "-2")]
        [TestCase("0", "0")]
        [TestCase("0", "1")]
        [TestCase("1", "0")]
        [TestCase("test", "3")]
        [TestCase("3", "test")]
        [TestCase("test", "test")]
        [TestCase("3.3", "3")]
        [TestCase("3", "3.3")]
        [TestCase("3.3", "3.3")]
        [TestCase(null, "test")]
        [TestCase("test", null)]
        [TestCase(null, null)]
        public void Sum_WithNonNaturalNumberParameter_Returns0(string num1, string num2)
        {
            //Arrange
            var utility = new StringSum();

            //Act
            var result = utility.Sum(num1, num2);

            //Assert
            result.Should().Be("0");
        }
    }
}