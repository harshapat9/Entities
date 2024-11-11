using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Role
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public List<User> UsersInformation = new List<User>();
}
