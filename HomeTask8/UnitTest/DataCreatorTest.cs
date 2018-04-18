using NUnit.Framework;
using System.Collections.Generic;
using HomeTask8;

namespace UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(20.0)]
        public void AvarageAge_Test(double expectedValue)
        {
            DataCreator dataInfo = new DataCreator();
            List<User> users = new List<User>();
            users.Add(new User("Zhenya", "Loban", "man", 20));
            users.Add(new User("Anna", "Moroz", "woman", 10));
            users.Add(new User("Adam", "Loban", "man", 30));
            double actualValue = dataInfo.AverageAge(users);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void OldestUsers_OneSeniorPerson()
        {
            DataCreator dataInfo = new DataCreator();
            List<User> users = new List<User>();
            users.Add(new User("Zhenya", "Loban", "man", 20));
            users.Add(new User("Anna", "Moroz", "woman", 10));
            users.Add(new User("Adam", "Loban", "man", 25));
            List<User> actualUsers = dataInfo.OldestUsers(users);
            foreach(User nextUser in actualUsers)
            {
                Assert.AreEqual(25,nextUser.age);
            }
        }
        [Test]
        public void OldestUsers_SeveralPeopleWithTheSameAge()
        {
            DataCreator dataInfo = new DataCreator();
            List<User> users = new List<User>();
            users.Add(new User("Zhenya", "Loban", "man", 20));
            users.Add(new User("Anna", "Moroz", "woman", 30));
            users.Add(new User("Adam", "Loban", "man", 30));
            List<User> expectedUsers = new List<User>();
            expectedUsers.Add(new User("Anna", "Moroz", "woman", 30));
            expectedUsers.Add(new User("Adam", "Loban", "man", 30));
            List<User> actualUsers = dataInfo.OldestUsers(users);
            for (int i = 0; i < actualUsers.Count; i++)
            {
                Assert.AreEqual(actualUsers[i].age, expectedUsers[i].age);
                Assert.AreEqual(actualUsers[i].sex, expectedUsers[i].sex);
                Assert.AreEqual(actualUsers[i].lastName, expectedUsers[i].lastName);
                Assert.AreEqual(actualUsers[i].firstName, expectedUsers[i].firstName);
            }
        }

        [Test]
        public void MostPopularWomanName_NoWomenInUserList()
        {
            DataCreator dataInfo = new DataCreator();
            List<User> users = new List<User>();
            users.Add(new User("Zhenya", "Loban", "man", 19));
            users.Add(new User("Adam", "Loban", "man", 25));
            List<string> popularName = dataInfo.MostPopularWomanName(users);
            Assert.AreEqual(popularName, null );
        }

        [Test]
        public void MostPopularWomanName_OneWomanOnTheLlist()
        {
            DataCreator dataInfo = new DataCreator();
            List<User> users = new List<User>();
            users.Add(new User("Zhenya", "Loban", "man", 19));
            users.Add(new User("Anna", "Moroz", "woman", 30));
            users.Add(new User("Adam", "Loban", "man", 25));
            List<string> popularName = dataInfo.MostPopularWomanName(users);
            foreach (string name in popularName)
            {
                Assert.AreEqual(name,"Anna");
            }
        }

        [Test]
        public void MostPopularWomanName_TwoEquallyPopularNames()
        {
            DataCreator dataInfo = new DataCreator();
            List<User> users = new List<User>();
            users.Add(new User("Kate", "Loban", "woman", 19));
            users.Add(new User("Kate", "Moroz", "woman", 30));
            users.Add(new User("Anna", "Moroz", "woman", 30));
            users.Add(new User("Anna", "Loban", "woman", 19));
            List<string> expectedName = new List<string>()
            { "Kate","Anna"};
            List<string> popularName = dataInfo.MostPopularWomanName(users);
            for (int i = 0; i < popularName.Count; i++)
            {
                Assert.AreEqual(popularName[i], expectedName[i]);
            }
        }

        [Test]
        public void MostPopularWomanName_OneMostPopularName()
        {
            DataCreator dataInfo = new DataCreator();
            List<User> users = new List<User>();
            users.Add(new User("Kate", "Loban", "woman", 19));
            users.Add(new User("Kate", "Moroz", "woman", 30));
            users.Add(new User("Zhenya", "Loban", "man", 19));
            users.Add(new User("Anna", "Loban", "woman", 19));
            List<string> expectedName = new List<string>()
            { "Kate"};
            List<string> popularName = dataInfo.MostPopularWomanName(users);
            for (int i = 0; i < popularName.Count; i++)
            {
                Assert.AreEqual(popularName[i], expectedName[i]);
            }
        }
    }
}
