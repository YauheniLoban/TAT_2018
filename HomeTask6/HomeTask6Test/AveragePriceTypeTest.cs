using NUnit.Framework;
using HomeTask6;
using System;

namespace HomeTask6Test
{
    [TestFixture]
    public class AveragePriceTypeTest
    {
        [TestCase(new string[] { "pen", "pen" }, new string[] { "add", "app" }, new string[] { "2", "1" }, new string[] { "200", "200" }, "pen", 200)]
        [TestCase(new string[] { "pen", "pen" }, new string[] { "add", "app" }, new string[] { "1", "1" }, new string[] { "200,5", "200.3" }, "pen", 200.4)]
        [TestCase(new string[] { "pen" }, new string[] { "add" }, new string[] { "8" }, new string[] { "300" }, "pen", 300)]
        public void AvaragePrice_Test(string[] type, string[] name, string[] quantity, string[] cost, string specificType, double result)
        {
            Storage listOfProducts = new Storage();
            for (int i = 0; i < type.Length; i++)
            {
                listOfProducts.AddingNewItemToListOfProducts(type[i], name[i], quantity[i], cost[i]);
            }
            listOfProducts.CalculationType = new AveragePriceType();
            Assert.AreEqual(result, listOfProducts.counting(specificType));
        }

        [TestCase(new string[] { }, new string[] { }, new string[] { }, new string[] { }, "pen")]
        [TestCase(new string[] { "pen", "pencil" }, new string[] { "add", "app" }, new string[] { "2", "1" }, new string[] { "200", "200" }, "marker")]
        public void AveragePriceType_ArgumentOutOfRangeException(string[] type, string[] name, string[] quantity, string[] cost, string specificType)
        {
            Storage listOfProducts = new Storage();
            for (int i = 0; i < type.Length; i++)
            {
                listOfProducts.AddingNewItemToListOfProducts(type[i], name[i], quantity[i], cost[i]);
            }
            listOfProducts.CalculationType = new AveragePriceType();
            Assert.Throws<ArgumentOutOfRangeException>
             (
               () => listOfProducts.counting(specificType)
             );
        }
    }
}
