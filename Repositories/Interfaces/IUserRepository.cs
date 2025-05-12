using SanAndres_Api.Dtos;
using SanAndres_Api.Models;

namespace SanAndres_Api.Repositories.Interfaces
{
  
  public interface IUserRepository
  {
    Task<User> GetUserByAuth(AuthRequestDto auth);
    Task<User> GetUserAuthById(int id);
    Task<User> CreateUser(User create, Guid salt);
    Task<User> GetUserByName(string name);
    Task<User> GetUserByEmail(string email);
  }
}