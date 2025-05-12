using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface IAuthService
  {
    Task<AuthResponseDto> Login(AuthRequestDto request);
    Task<AuthResponseDto> RefreshToken(int idUser);
    Task<AuthResponseDto> RegisterUser(AuthRegisterDto register);
    Task<bool> ValidateRefreshToken(AuthRefreshTokenRequestDto auth, int idUser);
  }
}