using System;

// This class represents a customer
public class Customer
{
    // Private member variables
    private string _name;
    private Address _address;  // Composition - Customer HAS an Address

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Check if customer lives in USA (delegates to Address)
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Get customer name
    public string GetName()
    {
        return _name;
    }

    // Get customer address
    public Address GetAddress()
    {
        return _address;
    }
}