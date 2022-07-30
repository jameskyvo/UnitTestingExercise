using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(12, 3, 15, 30)]
        [InlineData(2, 53, 5, 60)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-133, 3, 5, -125)]
        [InlineData(2, 3, 50, 55)]
        [InlineData(6, 9, 7, 22)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var addTest = new Calculator ();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = addTest.Add(num1, num2, num3);


            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 3, 7)]//Add test data <-------
        [InlineData(7, 10, -3)]
        [InlineData(1, 3, -2)]
        [InlineData(0, 3, -3)]
        [InlineData(10, 10, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(10, 5, 5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtractTest = new Calculator ();
            //Act
            var actual = subtractTest.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, 0)]//Add test data <-------
        [InlineData(10, 10, 100)]
        [InlineData(2, 2, 4)]
        [InlineData(-3, 3, -9)]
        [InlineData(6, 2, 12)]
        [InlineData(310, -125, -38750)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiplyTest = new Calculator();
            //Act
            var actual = multiplyTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 1)]//Add test data <-------
        [InlineData(0, 10, 0)]
        [InlineData(140, 2, 70)]
        [InlineData(-40, 4, -10)]
        [InlineData(1, 1, 1)]

        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divideTest = new Calculator();

            //Act
            var actual = divideTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
