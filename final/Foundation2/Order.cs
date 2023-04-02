namespace Foundation2;

class Order {
    private Product[] products;
    private Customer customer;

    public Order(Product[] products, Customer customer) {
        this.products = products;
        this.customer = customer;
    }
    public double GetTotalCost() {
        double totalCost = 0;
        foreach (Product product in products) {
            totalCost += product.GetTotalPrice();
        }
        if (customer.IsInUSA()) {
            totalCost += 5;
        } else {
            totalCost += 35;
        }
        return totalCost;
    }
    public string GetPackingLabel() {
        string packingLabel = "";
        foreach (Product product in products) {
            packingLabel += product.GetName() + " (ID: " + product.ProductId() + ")\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel() {
        Customer customer = this.customer;
        string shippingLabel = customer.Name() + "\n" + customer.GetAddress().AddressString();
        return shippingLabel;
    }
}
