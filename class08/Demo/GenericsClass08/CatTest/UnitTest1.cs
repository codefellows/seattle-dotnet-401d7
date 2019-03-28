using GenericsClass08.Classes;
using Xunit;

namespace CatTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetCatName()
        {
            // Arrange
            Cat cat = new Cat();


            // Assert
            Assert.Equal("Josie", cat.Name);


        }

        [Fact]
        public void CanSetCatName()
        {
            Cat cat = new Cat();

            // Act
            cat.Name = "Belle";

            // Assert
            Assert.Equal("Belle", cat.Name);

        }

        [Fact]
        public void CanGetAge()
        {
            Cat cat = new Cat();

            Assert.Equal(8, cat.Age);
        }

        [Fact]
        public void CanChangeAge()
        {
            Cat cat = new Cat();
            cat.Age = 10;

            Assert.Equal(1, cat.Age);
        }
    }
}
