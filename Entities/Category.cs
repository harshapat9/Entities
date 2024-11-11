using Swashbuckle.AspNetCore.Annotations;

namespace ECommerce.Database;

public class Category
{
    [SwaggerIgnore]
    public int ID { get; set; }
    public string? Name { get; set; }
    public List<SubCategory>? SubCategories { get; set; }
}
