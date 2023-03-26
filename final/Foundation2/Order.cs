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

    public decimal CalculateTotalCost()
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
        string label = "";
        foreach (Product product in Products)
        {
            label += $"{product.Name} | {product.ProductID}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.FormatAddress()}";
    }
}