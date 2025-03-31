using System;

class Products
{
    private string ProductName;
    private int ProductID;
    private double ProductPrice;
    private int ProductQuantity;

    public Products (string ProductName, int ProductID, double ProductPrice, int ProductQuantity)
    {
        this.ProductName = ProductName;
        this.ProductID = ProductID;
        this.ProductPrice = ProductPrice;
        this.ProductQuantity = ProductQuantity;
    }
    public double GetTotalcost()
    {
        return ProductPrice * ProductQuantity;
    }

    public string ProductInfo()
    {
        return $"{ProductName} (ID: {ProductID})";
    }
}
