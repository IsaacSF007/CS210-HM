using System;

class Costumer
{
    private string CostumerName;
    private Address _address;

    public Costumer(string CostumerName, Address _address)
    {
        this.CostumerName = CostumerName;
        this._address = _address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return CostumerName;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}
