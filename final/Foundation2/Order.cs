using System;

class Order
{
    // Attributes
    private Customer _customer;
    private List<Product> _products;
    private double _total = 0;
    private double _shippingCost = 0;
    private double _orderSubtotal = 0;
    // private string _packingLabel = "";
    // private string _packingLabelDetails = "";

    // Constructors
    public Order()
    {

    }

    // Methods 
    public double CalculateShipping()
    {
        // If the customer lives in the USA, then the shipping cost is $5.
        if (_customer.GetResidency())
        {
            _shippingCost = 5;
        } 
        // If the customer does not live in the USA, then the shipping cost is $35.
        else if (_customer.GetResidency() == false)
        {
            _shippingCost = 35;
        }
        return _shippingCost;
    }
    
    public double CalculateOrderSubtotal(double productSubtotal)
    {
        // This runs after the CalculateCost is run for each product
        _orderSubtotal += productSubtotal;
        return _orderSubtotal;
    }
    
    public double CalculateTotal()
    {
        // Add up the subtotals for each individual product
        foreach (Product product in _products)
        {
            // CalculateSubtotal();  <-----error keeps occuring in this method
            double productSubtotal = product.CalculateCost(product.GetProductPrice(), product.GetQuantity());
            CalculateOrderSubtotal(productSubtotal);
        }
        // Add one-time shipping cost to the total
        _shippingCost = CalculateShipping();
        _total = _orderSubtotal + _shippingCost;
       return _total;
    }


    public string CreatePackingDetails(string productID, string productName)
        {
            return $"Product Name: {productName}, Product ID: {productID}";
        }

    public string CreateShippingLabel()
    {
        // A shipping label should list the name and address of the customer.
        return _customer.GetDisplayAddress();
    }

    public double SetSubtotal(double subtotal)
    {
        _orderSubtotal = subtotal;
        return _orderSubtotal;
    }
    public void SetProductsList(List<Product> productsList)
    {
        _products = productsList;
    }

    public void SetCustomerDetails(Customer customer)
    {
        _customer = customer;
    }
}