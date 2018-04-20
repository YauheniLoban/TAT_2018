using NUnit.Framework;
using HomeTask6;
using System;

namespace HomeTask6Test
{
    [TestFixture]
    public class AveragePriceTest
    {
        [TestCase(new string[] { "pen", "pencil" }, new string[] { "add", "app" }, new string[] { "2", "1" }, new string[] { "200", "200" }, 200)]
        [TestCase(new string[] { "pen" }, new string[] { "add" }, new string[] { "8" }, new string[] { "200" }, 200)]
        public void AvaragePrice_Test(string[] type, string[] name, string[] quantity, string[] cost, double result)
        {
            Storage listOfProducts = new Storage();
            for (int i = 0; i < type.Length; i++)
            {
                listOfProducts.AddingNewItemToListOfProducts(type[i], name[i], quantity[i], cost[i]);
            }
            listOfProducts.CalculationType = new AveragePrice();
            Assert.AreEqual(result, listOfProducts.counting(""));
        }

        [TestCase()]
        public void AvaragePrice_ArgumentOutOfRangeException()
        {
            Storage listOfProducts = new Storage();
            listOfProducts.CalculationType = new AveragePrice();
            Assert.Throws<ArgumentOutOfRangeException>
            (
               () => listOfProducts.counting("")
            );
        }
    }
}
