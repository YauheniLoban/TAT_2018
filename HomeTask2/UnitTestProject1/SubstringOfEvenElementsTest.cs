using System;
using Xunit;
using DevTask2;

namespace HomeTask2.Test
{
    public class SubstringOfEvenElementsTest
    {
        [Theory]
        [InlineData("nanan", "nnn")]
        [InlineData("nanana", "nnn")]
        [InlineData("Z", "Z")]
        public void CreateSubstringOfEvenElementsTest(string line, string resalt)
        {
            SubstringOfEvenElements evensElemenst = new SubstringOfEvenElements();
            string actial = evensElemenst.CreateSubstringOfEvenElements(line);
            Assert.Equal(resalt, actial);
        }

        [Theory]
        [InlineData("")]
        public void CreateSubstringOfEvenElementsTest_ArgumentException(string line)
        {
            SubstringOfEvenElements evensElemenst = new SubstringOfEvenElements();
            Assert.Throws<ArgumentException>
           (
              () => evensElemenst.CreateSubstringOfEvenElements(line)
           );
        }
    }
}
