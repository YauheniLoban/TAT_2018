using System;
using System.Collections.Generic;

namespace HomeTask6
{
    /// <summary> 
    /// class determining method of calculating the average cost per unit of a particular product
    /// </summary> 
    public class AveragePriceType : IStorable
    {
        public double counting(List<Product> listOfProducts, string type)
        {
            double total = 0;
            double totalCost = 0;
            foreach (Product nextItemInList in listOfProducts)
            {
                if (nextItemInList.TypeOfProduct == type)
                {
                    total = total + nextItemInList.QuantityOfProduct;
                    totalCost = totalCost + nextItemInList.CostPerUnit * nextItemInList.QuantityOfProduct;
                }
            }

            if (total == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return totalCost / total;
        }
    }
}
