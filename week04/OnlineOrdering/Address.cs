public class Address
{
    private string _street;
    private string _city;
    private string _state_province;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _state_province = stateProvince;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }
    public string GetFormattedAddress()
    {
        return $"{_street}\n{_city}, {_state_province}\n{_country}";
    }
}