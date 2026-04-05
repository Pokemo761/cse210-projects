using System;
using System.Collections.Generic;

// This class represents a customer order
public class Order
{
    // Private member variables
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate total cost (products + shipping)
    public decimal GetTotalCost()
    {
        decimal productTotal = 0;
        
        // Add up all product costs
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }
        
        // Add shipping cost
        decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
        
        return productTotal + shippingCost;
    }

    // Get packing label (list of all products)
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";
        label += "═════════════════════════════════\n";
        
        foreach (Product product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        
        return label;
    }

    // Get shipping label (customer name and address)
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";
        label += "═════════════════════════════════\n";
        label += _customer.GetName() + "\n";
        label += _customer.GetAddress().GetFullAddress() + "\n";
        
        return label;
    }
}