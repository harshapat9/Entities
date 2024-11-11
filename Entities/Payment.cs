using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Payment
{
    public int ID { get; set; }
    public Order? Order { get; set; }
    public int TotalAmount { get; set; }
    public bool IsPayment { get; set; }
}
