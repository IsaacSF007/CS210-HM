using System;

class Order
{
    private Costumer Costumer;
    private List<Products> Product = new List<Products>();

    public void AddProduct(Products product)
    {
        Product.Add(product);
    }

    public Order (Costumer costumer)
    {
        this.Costumer = costumer;
    }

    public Order()
    {
    }

    public double _GetTotalPrice ()
    {
        double total = 0;
        foreach (var product in Product)
        {
            total += product.GetTotalcost();
        }
        total += Costumer.IsInUSA() ? 5 : 35;
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Picking Label: ";
        foreach (var product in Product)
        {
            label += product.ProductInfo() + "\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{Costumer.GetName()}\n{Costumer.GetAddress()}";
    }

}
