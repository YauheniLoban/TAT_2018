using System.Collections.Generic;

namespace HomeTask6
{
    /// <summary> 
    /// class defining method of calculation number of product types
    /// </summary> 
    public class CountTypes : IStorable
    {
        public double counting(List<Product> listOfProducts, string type)
        {
            double numberOfTypes = 0;
            Product[] Array = listOfProducts.ToArray();
            for (int i = 0; i < Array.Length; i++)
            {
                numberOfTypes++;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i].TypeOfProduct == Array[j].TypeOfProduct)
                    {
                        Product temp = Array[j];
                        Array[j] = Array[i + 1];
                        Array[i + 1] = temp;
                        i++;
                    }
                }
            }
            return numberOfTypes;
        }
    }
}
