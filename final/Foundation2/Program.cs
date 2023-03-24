using System;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a product
            Product product1 = new Product("T-Shirt", "123", 10.99, 2);
            Product product2 = new Product("Hat", "456", 5.99, 1);
            Product product3 = new Product("Shoes", "789", 25.99, 1);

            // create a customer
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Customer customer1 = new Customer("John Smith", address1);

            // create an order
            Order order1 = new Order(customer1);

            // add products to the order
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            // display packing label and shipping label
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());

            // display total price
            Console.WriteLine($"Total price: {order1.GetTotalPrice():C}");

            // create another customer
            Address address2 = new Address("456 Main St", "Anytown", "CA", "Canada");
            Customer customer2 = new Customer("Jane Doe", address2);

            // create another order
            Order order2 = new Order(customer2);

            // add products to the order
            order2.AddProduct(product1);
            order2.AddProduct(product3);

            // display packing label and shipping label
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());

            // display total price
            Console.WriteLine($"Total price: {order2.GetTotalPrice():C}");
        }
    }
}
