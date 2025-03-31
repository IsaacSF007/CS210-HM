using System;

class Program
{
    static void Main(string[] args)
    {
        Address _address1 = new Address("Av. Reforma 200", "CDMX", "Mexico", "Mexico");
        Address _address2 = new Address("123 Main St", "New York", "NY", "USA");

        Costumer costumer1 = new Costumer("Isaac Sabino", _address1);
        Costumer costumer2 = new Costumer("Alexandra Figuereo", _address2);

        Products product1 = new Products("Laptop", 101, 800, 1);
        Products product2 = new Products("Mouse", 102, 20, 2);
        Products product3 = new Products("Keyboard", 103, 50, 1);

        Order order1 = new Order(costumer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(costumer2);
        order2.AddProduct(product3);


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: ${order1._GetTotalPrice()}");

       Console.WriteLine(order2.GetPackingLabel());
       Console.WriteLine(order2.GetShippingLabel());
       Console.WriteLine($"Total price: ${order2._GetTotalPrice()}");




    }
}