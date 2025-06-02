namespace SanAndres_Api.Models
{
  public class Token
  {
    public int Id { get; set;}
    public string CurrentToken { get; set;} 
    public string RefreshToken { get; set;} 
    public DateTime CreateDate { get; set;}
    public DateTime ExpiredDate { get; set;}
    public bool Active { get; set;}

    // Foreign Keys
    public int UserId { get; set;}

    // Refs
    public virtual User User {get; set;}

    public Token ()
    {
      Active = true;
    }
  }
}