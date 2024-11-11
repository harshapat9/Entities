using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Cart
{
    public int ID { get; set; }
    public User? User { get; set; }
    public int CustomerID { get; set; }
    public List<Product>? Products { get; set; } = new List<Product>();
}
