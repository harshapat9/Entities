using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Order
{
    public int ID { get; set; }
    public User? User { get; set; }
    public int UserID { get; set; }
    public Payment? Payment { get; set; }
    public int PaymentID { get; set; }
    public List<Product>? Products { get; set; }
    public DateTime? PurchaseDate { get; set; }

}
