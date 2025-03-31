using System;

class Address
{
    private string _street;
    private string  _city;
    private string _state;
    private string _country;

    public Address(string _street, string _city, string _state, string _country)
    {
        this._street = _street;
        this._city = _city;
        this._state = _state;
        this._country = _country;

        
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}