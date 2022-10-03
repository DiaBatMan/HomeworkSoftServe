using System;

public class Products
{
    public string Name;
    public DateTime ManufactureDate;
    public decimal Price;

    public Products(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        string info = "\nName: " + Name + "\nManufactureDate: " + ManufactureDate + "\nPrice: " + Price;

        return info;
    }
}
