using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Database;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;

namespace SanAndres_Api.Repositories
{
  
  public class TokenRepository : ITokenRepository
  {
    
    private readonly DataContext _context;
    public TokenRepository(DataContext context)
    {
      _context = context;
    }

    public async Task<Token> CreateToken(Token token, int userId, int timeValidMin)
    {
      token.UserId = userId;
      token.CreateDate = DateTime.UtcNow;
      token.ExpiredDate = DateTime.UtcNow.AddMinutes(timeValidMin);

      await _context.Tokens.AddAsync(token);
      await _context.SaveChangesAsync();

      return token;
    }

    public async Task<Token> GetTokenRefresh(AuthRefreshTokenRequestDto req, int idUser)
    {
      var refresToken = await _context.Tokens
        .FirstOrDefaultAsync(r => 
          r.RefreshToken == req.RefreshToken && r.CurrentToken== req.TokenExpired && r.UserId == idUser && r.Active == true
      );

      return refresToken;
    }

    public async Task DesactiveToken(int userId)
    {
      var token = await _context.Tokens
        .Where(t => t.UserId == userId)
        .OrderByDescending(t => t.CreateDate)
        .FirstOrDefaultAsync();

      if(token != null)
      {
        token.Active = false;
        _context.Tokens.Update(token);

        await _context.SaveChangesAsync();
      }
    }

    public async Task DropToken(int id)
    {
      var token = await _context.Tokens.Where(t => t.Id == id).FirstOrDefaultAsync();

      _context.Tokens.Remove(token);
      await _context.SaveChangesAsync();
    }
  }
}