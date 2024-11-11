using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Annotations;

namespace ECommerce.Database;

public class SubCategory
{
    [SwaggerIgnore]
    public int ID { get; set; }
    public Category? Category { get; set; }
    public int CategoryID { get; set; }
    public string? Name { get; set; }
    public List<Product>? Products { get; set; }
}
