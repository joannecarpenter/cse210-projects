using System;

class Address
{
    // Attributes
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipcode;

    // Constructor
    public Address(string streetAddress, string city, string state, string zipcode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }

    // Method
    public string DisplayAddress()
    {
       return $"{_streetAddress}, {_city}, {_state} {_zipcode}";     
    }

}