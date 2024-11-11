using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using ECommerce.Utilities;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;

namespace ECommerce.Database;

public class User
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public List<Address>? Addresses { get; set; } = new List<Address>();
    public List<Order>? Orders { get; set; } = new List<Order>();
    public Cart? Cart { get; set; }
    public Wishlist? Wishlist { get; set; }
    public Role? Role { get; set; }
    public int RoleID { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public DateTime LastLogin { get; set; }
    public bool IsActive { get; set; }
}
