using System;
using NUnit.Framework;
using HomeTask11;

namespace UnitTestProject1
{
    [TestFixture]
    public class CountThePastNumberOfDaysTest
    {
        [TestCase(9, 1, 1, 8)]
        [TestCase(1, 1, 2, 365)]
        [TestCase(1, 2, 1, 31)]
        public void CountThePastNumberOfDaysTest_ValidValues(int day, int month, int year, int result)
        {
            DateConverterWebService webServis = new DateConverterWebService();
            Assert.AreEqual(result, webServis.CountThePastNumberOfDays(day, month, year));
        }

        [TestCase(-2, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(2, 1, -1)]
        [TestCase(32, 1, 1)]
        [TestCase(1, 13, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        public void CountThePastNumberOfDaysTest_ArgumentException(int day, int month, int year)
        {
            DateConverterWebService webServis = new DateConverterWebService();
            Assert.Throws<ArgumentException>
           (
              () => webServis.CountThePastNumberOfDays(day, month, year)
           );
        }
    }
}
