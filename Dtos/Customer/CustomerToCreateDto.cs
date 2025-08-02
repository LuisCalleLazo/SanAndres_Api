using System.Text.Json.Serialization;

namespace SanAndres_Api.Dtos
{
  public class CustomerToCreateDto : CustomerDto
  {
    [JsonIgnore]
    public DateTime CreateAt { get; set; }
    public CustomerToCreateDto()
    {
      CreateAt = DateTime.UtcNow;
    }
  }
}