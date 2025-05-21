public class Order{
    private List<Product> products = new List<Product>();
    private Customer customer;
    public Order(Customer customer){
        this.customer = customer;
    }
    public void AddProduct(Product product){
        products.Add(product);
    }
    public double GetTotalCost(){
        double total = 0;
        foreach(Product product in products){
            total += product.TotalPrice();
}
        total += customer.GetAddress().IsUSA() ? 5.00 : 10.00;
        return total;
    }
    public string GetPackingLabel(){
        string label = "Packing Label:\n";
        foreach(Product product in products){
            label += product.GetPackageLabel() + "\n";
        }
        return label;
    }
    public string GetShippingLabel(){
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
    
}