using System;
using System.Collections.Generic;
using System.Threading;

namespace HomeTask6
{
    /// <summary> 
    /// class to create a list of products and work with it
    /// </summary>
    public class Storage
    {
        private List<Product> listOfProducts = new List<Product>();
        // private IStorable calculationType;
        private IStorable calculationType;

        /// <summary> 
        /// Adds a new product to the list of products, if its parameters are correct
        /// </summary> 
        /// <param name="type">Type of products </param>
        /// <param name="name">Name of products </param>
        /// <param name="quantity">number of unit</param>
        /// <param name="cost">Unit price </param>
        public void AddingNewItemToListOfProducts(string type, string name, string quantity, string cost)
        {
            double quantityInDouble = 0;
            double costInDouble = 0;
            char delimiterInFractionalNumbers = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!Double.TryParse(quantity, out quantityInDouble))
            {
                quantity = quantity.Replace('.', delimiterInFractionalNumbers);
                quantity = quantity.Replace(',', delimiterInFractionalNumbers);
            }
            if (!Double.TryParse(cost, out costInDouble))
            {
                cost = cost.Replace('.', delimiterInFractionalNumbers);
                cost = cost.Replace(',', delimiterInFractionalNumbers);
            }
            if (type == string.Empty || name == string.Empty || !Double.TryParse(quantity, out quantityInDouble) || !Double.TryParse(cost, out costInDouble) || Double.Parse(quantity) <= 0 || Double.Parse(cost) <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                quantityInDouble = Double.Parse(quantity);
                costInDouble = Double.Parse(cost);
                Product newItemForTheList = new Product(type, name, quantityInDouble, costInDouble);
                listOfProducts.Add(newItemForTheList);
            }
        }

        /// <summary> 
        /// produces calculations depending on the scenario
        /// </summary> 
        public double counting(string type)
        {
            return calculationType.counting(listOfProducts, type);
        }

        public IStorable CalculationType
        {
            set
            {
                calculationType = value;
            }
        }
    }
}
