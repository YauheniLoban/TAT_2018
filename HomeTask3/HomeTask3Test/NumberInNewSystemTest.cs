using System;
using NUnit.Framework;
using DevTask3;

namespace HomeTask3.Test
{
    [TestFixture]
    public class NumberInNewSystemTest
    {
        [TestCase(255, 16, "FF")]
        [TestCase(10, 2, "1010")]
        [TestCase(20, 20, "10")]
        [TestCase(Int32.MaxValue, 20, "1DB1F927")]
        [TestCase(0, 10, "0")]
        [Test]
        public void CreatingRepresentationOfNumberInNewSystemTest(int acceptedNumber, int ecceptedFoundetion, string result)
        {
              // act
                NumberInNewSystem ptr = new NumberInNewSystem(acceptedNumber, ecceptedFoundetion);
                string actial = ptr.CreatingRepresentationOfNumberInNewSystem();
              // assert
              Assert.AreEqual(result, actial);  
                    
        }
        [TestCase(-1, 20)]
        [TestCase(255, 1)]
        [TestCase(255, 21)]
        [Test]
        public void CreatingRepresentationOfNumberInNewSystemTest_ArgumentOutOfRangeException(int acceptedNumber, int ecceptedFoundetion)
        {
            NumberInNewSystem ptr = new NumberInNewSystem(acceptedNumber, ecceptedFoundetion);
            Assert.Throws<ArgumentOutOfRangeException>
             ( 
                () => ptr.CreatingRepresentationOfNumberInNewSystem() 
             );
        }
    }
}
