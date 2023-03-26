using System;

public class Product
{
    public string Name { get; init; }

    public string ProductID { get; init; }

    public decimal Price { get; init; }

    public int Quantity { get; init; }

    public Product(string name, string productid, decimal price, int quantity)
    {
        Name = name;
        ProductID = productid;
        Price = price;
        Quantity = quantity;
    }

    public decimal TotalPrice()
    {
        return Price*Quantity;
    }
}