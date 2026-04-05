using System;

// This class represents a product that can be ordered
public class Product
{
    // Private member variables
    private string _name;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Calculate the total cost of this product (price × quantity)
    public decimal GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    // Get product name
    public string GetName()
    {
        return _name;
    }

    // Get product ID
    public string GetProductId()
    {
        return _productId;
    }

    // Get packing label info for this product
    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}