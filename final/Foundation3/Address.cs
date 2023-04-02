using System;

public class Address
{
    public string _street = "";

    public string _city = "";

    public string _province = "";

    public string _country = "";

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country; 
    }

    public override string ToString()
    {
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }
}