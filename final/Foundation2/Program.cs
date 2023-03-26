using System;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        List<Order> orders = program.CreateOrders();
        
        program.Display(orders);
    }

    private void Display(List<Order> orders)
    {
        string divider = new string ('=',30);
        Console.Clear();
        foreach (Order order in orders)
        {
            Console.WriteLine(divider);
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine();
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine("Total Cost:");
            Console.WriteLine($"${order.TotalCost()}");
        }

        Console.WriteLine(divider);
    }

    private List<Order> CreateOrders()
    {
        List<Order> orders = new List<Order>();
        Customer customer = new Customer("John Doe", new Address("Park Ave", "New York City", "New York", "USA"));
        Order order = new Order(customer);
        order.Products.Add(new Product("Battery", "B1Kl80014", 2.05M, 12));
        order.Products.Add(new Product("Mop", "ER129K80034", 13.50M, 1));
        orders.Add(order);

        customer = new Customer("Susie Lou", new Address("32nd Street", "Toronto", "Ontario", "Canada"));
        order = new Order(customer);
        order.Products.Add(new Product("Lightbulb", "ROUW81414", 3.45M, 6));
        order.Products.Add(new Product("Cook Book", "GHONKAO034", 34.10M, 2));
        orders.Add(order);

        return orders;
    }
}