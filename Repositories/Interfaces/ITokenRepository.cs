using SanAndres_Api.Dtos;
using SanAndres_Api.Models;

namespace SanAndres_Api.Repositories.Interfaces
{
  public interface ITokenRepository
  {
    Task<Token> CreateToken(Token token, int userId, int timeValidMin);
    Task<Token> GetTokenRefresh(AuthRefreshTokenRequestDto auth, int idUser);
    Task DesactiveToken(int userId);
    Task DropToken(int id);
  }
}