namespace ECommerce.Database;

public class OrderProducts
{
    public int ID { get; set; }
    public Order? Order { get; set; }
    public int OrderID { get; set; }
    public Product? Product { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
}
