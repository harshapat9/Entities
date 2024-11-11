using System.Text.Json.Serialization;
using Azure.Core.Pipeline;

namespace ECommerce.Database;

public class Product
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Category? Category { get; set; }
    public int CategoryID { get; set; }
    public SubCategory? Subcategory { get; set; }
    public int SubCategoryID { get; set; }
    public string? Brand { get; set; }
    public int Quantity { get; set; }
    public int CostPrice { get; set; }
    public int SellingPrice { get; set; }
    public List<Review>? Reviews { get; set; } = new List<Review>();
    public List<Cart>? Carts { get; set; } = new List<Cart>();
    public List<Order> Orders { get; set; } = new List<Order>();
    public List<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
    public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public string? ModifiedBy { get; set; }
    public bool IsActive { get; set; }

}
