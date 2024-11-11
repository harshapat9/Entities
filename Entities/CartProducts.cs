using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class CartProducts
{
    public int ID { get; set; }
    public Cart? Cart { get; set; }
    public int CartID { get; set; }
    public Product? Product { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public bool ProceedToOrder { get; set; }
}
