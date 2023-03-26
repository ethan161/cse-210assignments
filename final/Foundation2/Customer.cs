using System;

public class Customer
{
    public string Name { get; init; }

    public Address Address { get; init; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}