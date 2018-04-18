using NUnit.Framework;
using System.Collections.Generic;
using HomeTask8;

namespace UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(20.0)]
        public void CountAverageAge_CalculateAverageAge_AverageAge(double expectedValue)
        {
            DataCreator dataInfo = new HomeTask8.DataCreator();
            List<User> users = new List<User>();
            users.Add(new User("aaa", "AAA", "man", 20));
            users.Add(new User("bbb", "BBB", "woman", 10));
            users.Add(new User("ccc", "AAA", "man", 30));
            double actualValue = dataInfo.CountAverageAge(users);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
