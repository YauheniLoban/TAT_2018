namespace HomeTask6
{
    /// <summary> 
    /// This class for creating product information
    /// </summary>
    public class Product
    {
        private string typeOfProduct;
        private string nameOfProduct;
        private double quantityOfProduct;
        private double costPerUnit;

        public Product(string type, string name, double quantity, double cost)
        {
            typeOfProduct = type;
            nameOfProduct = name;
            quantityOfProduct = quantity;
            costPerUnit = cost;
        }

        public string TypeOfProduct
        {
            get { return typeOfProduct; }
        }

        public string NameOfProduct
        {
            get { return nameOfProduct; }
        }

        public double QuantityOfProduct
        {
            get { return quantityOfProduct; }
        }

        public double CostPerUnit
        {
            get { return costPerUnit; }
        }
    }
}
