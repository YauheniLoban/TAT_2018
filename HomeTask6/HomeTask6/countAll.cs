using System.Collections.Generic;

namespace HomeTask6
{
    /// <summary> 
    /// class determining method of calculation total number of unit
    /// </summary> 
    public class CountAll : IStorable
    {
        public double counting(List<Product> listOfProducts, string type)
        {
            double total = 0;

            foreach (Product nextItemInList in listOfProducts)
            {
                total = total + nextItemInList.QuantityOfProduct;
            }
            return total;
        }
    }
}