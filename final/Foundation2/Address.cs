using System;

public class Address
{
    // Attributes
    private string _streetAddress = "";
    private string _city = "";
    private string _stateOrProvince = "";
    private string _country = "";
    
    // Constructors
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // Methods 
    public bool ResidesInUSA()
    {   
        if (_country != "USA")
       {
            return false;
       }
       return true;
    }

    public string DisplayAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}, {_country}";
    }
        
    

}