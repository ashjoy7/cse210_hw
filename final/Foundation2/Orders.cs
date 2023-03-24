using System.Collections.Generic;
using System.Text;

namespace ProductOrderingSystem
{
    class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }

            if (customer.Address.IsInUSA())
            {
                totalPrice += 5;
            }
            else
            {
                totalPrice += 35;
            }

            return totalPrice;
        }

        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder();
            foreach (Product product in products)
            {
                packingLabel.AppendLine($"{product.Name} ({product.ProductID})");
            }

            return packingLabel.ToString();
        }

        public string GetShippingLabel()
        {
            return $"{customer.Name}\n{customer.Address.ToString()}";
        }
    }
}
