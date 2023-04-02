﻿namespace Foundation2;

class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;
    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
    public string GetName() { return name; }
    public string ProductId() { return productId; }
    public double GetTotalPrice() {
        return price * quantity; }
}
