using System;
using System.Collections.Generic;

namespace HomeTask6
{
    /// <summary> 
    /// class determining method of calculating the average cost per unit of all product
    /// </summary> 
    public class AveragePrice : IStorable
    {
        public double counting(List<Product> listOfProducts, string type)
        {
            if (listOfProducts.Count == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double total = 0;
            double totalCost = 0;
            foreach (Product nextItemInList in listOfProducts)
            {
                total = total + nextItemInList.QuantityOfProduct;
                totalCost = totalCost + nextItemInList.CostPerUnit * nextItemInList.QuantityOfProduct;
            }
            return totalCost / total;
        }
    }
}
