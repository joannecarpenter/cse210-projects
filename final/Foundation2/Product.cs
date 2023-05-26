using System;

class Product
{
    // Attributes
    private string _productName;
    private string _productID;
    private double _productPrice;
    private double _quantity;

    // Constructors
    public Product(string productName, string productID, double productPrice, double quantity)
    {
        // Contains the name, product id, price, and quantity of each product.
        // Pull these values by index from the list of products 
            // and enter that into parameters when using this constructor in the program
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    // Methods 
    public double CalculateCost(double productPrice, double quantity)
    {   
       // When this method is called, the arguments will be the index value of _productPrice and _quantity
       _productPrice = productPrice;
       _quantity = quantity;
       return _productPrice * _quantity;
    }

    public string DisplayProduct()
    {
        return $"{_productName}, {_productID}, {_productPrice}, {_quantity}";
       // Maybe I don't need this if the product itself stores in the list as product type  
    }

    public double GetProductPrice()
    {
        return _productPrice;
    }
    public double GetQuantity()
    {
        return _quantity;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public string GetProductName()
    {
        return _productName;
    }

}