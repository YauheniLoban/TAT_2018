using NUnit.Framework;
using System;
using Test_Progect2;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(5,5,25)]
        [TestCase(2.5, 2.5, 6.25)]
        public void CalculateSquare_ValidValues(double width, double length, double result)
        {
            Rectangle rectangle = new Rectangle(width, length);
            Assert.AreEqual(rectangle.CalculateSquare(), result);
        }

        [TestCase(0, 10)]
        [TestCase(10, 0)]
        [TestCase(-10, 10)]
        [TestCase(10, -10)]
        public void CalculateSquare_ArgumentException(double width, double length)
        {
            Assert.Throws<ArgumentException>
            (
              () =>new Rectangle(width, length)
            );
        }
    }
}
