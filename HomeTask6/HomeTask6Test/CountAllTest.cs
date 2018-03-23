using NUnit.Framework;
using HomeTask6;

namespace HomeTask6Test
{
    [TestFixture]
    public class CountAllTest
    {
        [TestCase(new string[] { "pen", "pencil" }, new string[] { "add", "app" }, new string[] { "8", "8" }, new string[] { "200", "200" }, 16)]
        [TestCase(new string[] { "pen" }, new string[] { "add" }, new string[] { "8" }, new string[] { "200" }, 8)]
        public void CountAll_Test(string[] type, string[] name, string[] quantity, string[] cost, double result)
        {
            Storage listOfProducts = new Storage();
            for (int i = 0; i < type.Length; i++)
            {
                listOfProducts.AddingNewItemToListOfProducts(type[i], name[i], quantity[i], cost[i]);
            }
            listOfProducts.CalculationType = new CountAll();
            Assert.AreEqual(result, listOfProducts.counting(""));
        }

        [TestCase(0)]
        public void CountAll_ZeroElements(double result)
        {
            Storage listOfProducts = new Storage();
            listOfProducts.CalculationType = new CountAll();
            Assert.AreEqual(result, listOfProducts.counting(""));
        }
    }
}

