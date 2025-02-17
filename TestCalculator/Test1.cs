using LearnMyCalculator;

namespace TestCalculator
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(1, 1);

            // Assert
            Assert.AreEqual(2, actual);
        }
        public void SubtractTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(1, 1);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(1, 1);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 1);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void CircleAreaTest()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            // Act
            double actualArea = Calculator.CircleArea(radius);
            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 0);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void CosTest()
        {
            var actual = Calculator.Cos(Math.PI / 2);
            Assert.AreEqual(0, actual, 0.001);
        }

    }
}
