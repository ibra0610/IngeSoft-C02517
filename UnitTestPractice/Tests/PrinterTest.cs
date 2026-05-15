using UnitTestPractice;
using NUnit.Framework;
using Moq;
using System.Security.Cryptography.X509Certificates;

namespace Tests
{
    [TestFixture]
    public class PrinterTest
    {
        Printer _printer;
        IDependency _dependency;

        [SetUp]
        public void Setup()
        {
            _dependency = new Mock<IDependency>().Object;
            _printer = new Printer(_dependency);
        }

        [Test]
        public void Print_Works_Correctly()
        {
            // Arrange
            var expectedResult = "print completed";


            // Act

            var result = _printer.Print();
            

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}
