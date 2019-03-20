using UnitTestingFizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturn1()
        {
            // Arrange

            // Act
            string number = Program.FizzBuzz(1);

            // Assert
            Assert.Equal("1", number);

        }

        [Fact]
        public void CanReturn2()
        {
            // Arrange

            // Act
            string number = Program.FizzBuzz(2);

            // Assert
            Assert.Equal("2", number);
        }

        [Fact]
        public void CanReturnFizzfor3()
        {
            string number = Program.FizzBuzz(3);

            // Assert
            Assert.Equal("Fizz", number);
        }

        [Fact]
        public void CanReturnBuzzfor5()
        {
            string number = Program.FizzBuzz(5);

            // Assert
            Assert.Equal("Buzz", number);
        }

    
        public void CanReturnFizzBuzzFor15()
        {
            string number = Program.FizzBuzz(15);

            // Assert
            Assert.Equal("FizzBuzz", number);
        }

        [Fact]
        public void CanReturnFizzFor9()
        {
            string number = Program.FizzBuzz(9);

            // Assert
            Assert.Equal("Fizz", number);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(33)]

        public void CanReturnFizzForNumbersDivisibleBy3(int value)
        {
            string number = Program.FizzBuzz(value);

            Assert.Equal("Fizz", number);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]

        public void CanReturnFizzBuzzGame(int actualValue, string expected)
        {
            string number = Program.FizzBuzz(actualValue);

            Assert.Equal(expected, number);
        }
    }
}
