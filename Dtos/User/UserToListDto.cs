namespace SanAndres_Api.Dtos
{
  public class UserToListDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int RolId { get; set; }
    public string FirstName {get; set;} 
    public string MomLastName {get; set;} 
    public string DadLastName {get; set;} 
    public DateTime BirthDate {get; set;}
    public string City {get; set;} 
    public string Ci {get; set;}
  }
}