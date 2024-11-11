namespace ECommerce.Database;

public class WishlistProducts
{
    public int ID { get; set; }
    public Wishlist? Wishlist { get; set; }
    public int WishlistID { get; set; }
    public Product? Product { get; set; }
    public int ProductID { get; set; }
}   
