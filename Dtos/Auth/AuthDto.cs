namespace SanAndres_Api.Dtos
{
  public class AuthRequestDto
  {
    public string NameOrGmail { get; set; }
    public string Password { get; set; }
  }

  public class AuthResponseDto
  {
    public string CurrentToken {get; set;}
    public string RefreshToken { get; set; }
    public UserResponseDto User { get; set; }
  }
  
  public class AuthJwtDto
  {
    public string Key { get; set; } 
    public string Issuer { get; set; } 
    public string Audience { get; set; } 
    public string Subject { get; set; } 
    public int TimeValidMin {get; set;}
  }
  public class AuthRegisterDto
  {
    public string Name {get; set;} 
    public string Email { get; set; }
    public string Password { get; set; } 
    public string FirstName {get; set;} 
    public string MomLastName {get; set;} 
    public string DadLastName {get; set;} 
    public DateTime BirthDate {get; set;}
    public string City {get; set;} 
    public string Ci {get; set;}
  }
  public class AuthRefreshTokenRequestDto
  {
    public string TokenExpired {get; set;} 
    public string RefreshToken {get; set;} 
  }
}