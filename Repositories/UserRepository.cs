using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Database;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Security;

namespace SanAndres_Api.Repositories
{

  public class UserRepository : IUserRepository
  {
    private readonly DataContext _context;
    public UserRepository(DataContext context)
    {
      _context = context;
    }

    public async Task<User> GetUserByAuth(AuthRequestDto auth)
    {
      var user = await _context.Users
        .Where(u => u.Name == auth.NameOrGmail || u.Email == auth.NameOrGmail)
        .FirstOrDefaultAsync();

      if (user == null) return null;

      if (!PasswordHashSecurity.VerifyPassword(user.Password, auth.Password, user.PasswordSalt)) return null;

      return user;
    }
    public async Task<User> GetUserAuthById(int id)
    {
      var user = await _context.Users
        .Where(u => u.Id == id)
        .FirstOrDefaultAsync();

      return user;
    }


    public async Task<User> CreateUser(User create, Guid salt)
    {
      create.PasswordSalt = salt;

      await _context.Users.AddAsync(create);
      await _context.SaveChangesAsync();
      return create;
    }


    public async Task<User> GetUserByName(string name) =>
      await _context.Users
        .Where(u => u.Name == name)
        .FirstOrDefaultAsync();


    public async Task<User> GetUserByEmail(string email) =>
      await _context.Users
        .Where(u => u.Email == email)
        .FirstOrDefaultAsync();
    public async Task<bool> UserIsSeller(int userId) =>
      await _context.Sellers.FirstOrDefaultAsync(x => x.Id == userId) != null ? true : false;

    public async Task<bool> UserIsCustomer(int userId) =>
      await _context.Customers.FirstOrDefaultAsync(x => x.Id == userId) != null ? true : false;
  }
}