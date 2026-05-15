using UnitTestPractice;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator _calculatorWithInit;
        [SetUp]
        public void Setup()
        {
            _calculatorWithInit = new Calculator(5);
        }

        [Test]
        public void Sum_Works_With_default_value()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Sum(5);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Sum_Works_With_default_Null()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Sum(null);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Sum_Works_With_default_Negative()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Sum(-8);

            // Assert
            Assert.That(result, Is.EqualTo(-8));
        }

        [Test]
        public void Sum_Works_CorrectlyWith_Init()
        {

            // Act
            var result = _calculatorWithInit.Sum(5);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Rest_Works_With_default_Null()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Rest(null);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
