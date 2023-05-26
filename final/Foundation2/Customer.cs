using System;

class Customer
{
    // Attributes
    private string _customerName;
    private Address _customerAddress;
    
    
    // Constructors
    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    // Methods
    public bool GetResidency()
    {
        bool residency = _customerAddress.ResidesInUSA();
        return residency;
    } 

    public string GetDisplayAddress()
    {
        return _customerAddress.DisplayAddress();
    }

}