using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(3, 2, 1)]
        [InlineData(100, 8, 92)]
        [InlineData(3, 5, -2)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 4, 16)]
        [InlineData(5, 4, 20)]
        [InlineData(7, 2, 14)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(10, 2, 5)]
        [InlineData(21, 3, 7)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void IsHungry()
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();
            //Act
            string actual = test.ImHungry();
            //Assert
            Assert.Equal("I'm hungry!", actual);
        }

        //[Fact]
        //public void YourMethodName2()
        //{
        //    //Arrange

        //    //Act

        //    //Assert
        //}
    }
}
