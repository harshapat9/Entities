using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Annotations;

namespace ECommerce.Database;

public class Address
{
    [SwaggerIgnore]
    public int ID { get; set; }
    public User? User { get; set; }
    public int UserID { get; set; }
    public string? MobileNumber { get; set; }
    public int DoorNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public int PostalCode { get; set; }
    public string? Country { get; set; }
    public string? LandMark { get; set; }
    public bool IsActive { get; set; }

}
