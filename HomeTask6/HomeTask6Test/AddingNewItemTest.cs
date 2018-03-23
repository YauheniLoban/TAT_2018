using System;
using NUnit.Framework;
using HomeTask6;

namespace HomeTask6Test
{
    [TestFixture]
    public class AddingNewItemTest
    {
        [TestCase("", "aad", "5", "8")]
        [TestCase("pen", "", "5", "8")]
        [TestCase("pen", "ADD", "-5", "8")]
        [TestCase("pen", "ADD", "5", "-8")]
        [TestCase("pen", "ADD", "", "8")]
        [TestCase("pen", "ADD", "5", "")]
        [TestCase("pen", "ADD", "5vs", "8")]
        [TestCase("pen", "ADD", "5", "8vs")]
        public void AddingNewItemToListOfProducts_ArgumentOutOfRangeException(string type, string name, string quantity, string cost)
        {
            Storage listOfProducts = new Storage();
            Assert.Throws<ArgumentOutOfRangeException>
             (
                () => listOfProducts.AddingNewItemToListOfProducts(type, name, quantity, cost)
             );
        }

        [TestCase("pen", "HH", "5", "200")]
        [TestCase("pen", "HH", "1", "200")]
        [TestCase("pen", "HH", "5", "1")]
        public void AddingNewItemToListOfProducts_Test(string type, string name, string quantity, string cost)
        {
            Storage listOfProducts = new Storage();
            listOfProducts.AddingNewItemToListOfProducts(type, name, quantity, cost);
        }
    }
}
