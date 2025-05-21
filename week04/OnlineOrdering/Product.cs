public class Product{
    private string name;
    private int productId;
    private double price;
    private int quantity;
    public Product(string name, int productId, double price, int quantity){
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
    public double TotalPrice(){
        return (double)(price * quantity);
    }
    public string GetPackageLabel(){
        return $"{name} - {productId}";
    }

}