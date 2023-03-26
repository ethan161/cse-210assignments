using System;

public class Order
{
    public List<Product> Products { get; init; }

    public Customer Customer { get; init; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public decimal TotalCost()
    {
        decimal cost = 0;
        foreach (Product product in Products)
        {
            cost += product.TotalPrice();
        }

        if (Customer.IsInUSA())
        {
            cost += 5;
        }
        else
        {
            cost += 35;
        }

        return cost;
    }

    public string PackingLabel()
    {
        List<string> items = new List<string>();
        foreach (Product product in Products)
        {
            items.Add($"{product.Name} | {product.ProductID}");
        }
        
        return string.Join("\n", items);
    }

    public string ShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.FormatAddress()}";
    }
}