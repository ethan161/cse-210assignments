using System;

public class Address
{
    public string Street { get; init; }

    public string City { get; init; }

    public string Province { get; init; }

    public string Country { get; init; }

    public string FormatAddress()
    {
        return $"{Street}\n{City}, {Province}\n{Country}";
    }

    public bool IsInUSA()
    {
        if (Country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}