using AutoMapper;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Security;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class AuthService : IAuthService
  {
    private readonly IConfiguration _config;
    private readonly IMapper _mapper;
    private readonly ITokenRepository _repo;
    // private readonly IUserRepository _userRepo;
    private readonly ITRepository _trepo;
    public AuthService(ITokenRepository repo, IConfiguration config, ITRepository trepo)
    {
      _repo = repo;
      _config = config;
      _trepo = trepo;
    }
    
    public async Task<AuthResponseDto> Authentication(User user)
    {
      var response = new AuthResponseDto();
      var jwt = _config.GetSection("JwtConfig").Get<AuthJwtDto>();
      response.User = _mapper.Map<UserResponseDto>(user);
      response.CurrentToken = JwtSecurity.GenerateToken(jwt, response.User, 1);
      response.RefreshToken = JwtSecurity.GenerateRefreshToken();
      await _repo.DesactiveToken(user.Id);
      await _repo.CreateToken(_mapper.Map<Token>(response), user.Id, jwt.TimeValidMin);
      return response;
    }

  }
}