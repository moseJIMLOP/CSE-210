public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
    public double GetShippingCost()
    {
        return _address.IsInUSA() ? 5.0 : 35.0;
    }
    public string GetFormattedAddress()
    {
        return _address.GetFormattedAddress();
    }
}