using SanAndres_Api.Dtos;
using SanAndres_Api.Models;

namespace SanAndres_Api.Services.Interfaces
{
  
  public interface IUserService
  {
    Task<User> GetUserByEmail(string email);
    Task<User> GetUserByName(string name);
    Task<List<UserToListDto>> GetUsers();
    Task<UserToListDto> PatchUser(UserToPatchDto patch, int userId);
    Task DeleteUser(int id);
  }
}