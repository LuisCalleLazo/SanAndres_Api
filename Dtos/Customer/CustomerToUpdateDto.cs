using System.Text.Json.Serialization;

namespace SanAndres_Api.Dtos
{
  public class CustomerToUpdateDto : CustomerDto
  {
    
    [JsonIgnore]
    public DateTime UpdateAt { get; set; }
    public CustomerToUpdateDto()
    {
      UpdateAt = DateTime.UtcNow;
    }
  }
}