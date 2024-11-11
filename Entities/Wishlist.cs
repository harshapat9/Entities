namespace ECommerce.Database;

public class Wishlist
{
    public int ID { get; set; }
    public User? User { get; set; }
    public int CustomerID { get; set; }
    public List<Product>? Products { get; set; } = new List<Product>();
}
