
namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product("Samsung Television", "101", 100.00, 1);
            Product product2 = new Product("Shampoo", "115", 8.00, 2);
            Product product3 = new Product("Call of Duty Game", "917", 70.00, 1);
            Product product4 = new Product("Bowls", "551", 5.00, 5);
            
            Address customer1Address = new Address("2842 Happy St", "Kennewick", "WA", "USA");
            Customer customer1 = new Customer("Keaton Davis", customer1Address);
            Address customer2Address = new Address("156 N 2nd S St", "Calgary", "AL", "Canada");
            Customer customer2 = new Customer("Lauren Davis", customer2Address);

            // Create some orders
            Order order1 = new Order(new Product[] { product1, product2, product3, product4 }, customer1);
            Order order2 = new Order(new Product[] { product1, product2, product3 }, customer2);
            
            Console.WriteLine("\nOrder 1 packing label:\n" + order1.GetPackingLabel());
            Console.WriteLine("Order 1 shipping label:\n" + order1.GetShippingLabel());
            Console.WriteLine("Order 1 total price: $" + order1.GetTotalCost());

            Console.WriteLine("\nOrder 2 packing label:\n" + order2.GetPackingLabel());
            Console.WriteLine("Order 2 shipping label:\n" + order2.GetShippingLabel());
            Console.WriteLine("Order 2 total price: $" + order2.GetTotalCost());
            
            Console.ReadLine();
        }
    }
}
