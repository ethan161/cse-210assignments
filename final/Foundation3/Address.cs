using System;

public class Address
{
    public string Street { get; init; }

    public string City { get; init; }

    public string Province { get; init; }

    public string Country { get; init; }

    public Address(string street, string city, string province, string country)
    {
        Street = street;
        City = city;
        Province = province;
        Country = country;
    }

    public string FormatAddress()
    {
        return $"{Street}\n{City}, {Province}\n{Country}";
    }

    public bool IsInUSA()
    {
        return Country == "USA";
    }
}