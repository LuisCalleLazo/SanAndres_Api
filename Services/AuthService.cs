using AutoMapper;
using SanAndres_Api.Dtos;
using SanAndres_Api.Helpers;
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
    private readonly IUserRepository _userRepo;
    private readonly ITRepository _trepo;
    public AuthService(ITokenRepository repo, IConfiguration config, ITRepository trepo, IUserRepository userRepo)
    {
      _repo = repo;
      _config = config;
      _trepo = trepo;
      _userRepo = userRepo;
    }
    
    public async Task<AuthResponseDto> Authentication(User user)
    {
      var response = new AuthResponseDto();
      var jwt = _config.GetSection("JwtSettings").Get<JwtSettings>();
      response.User = _mapper.Map<UserResponseDto>(user);
      response.CurrentToken = JwtSecurity.GenerateToken(jwt, response.User, 1);
      response.RefreshToken = JwtSecurity.GenerateRefreshToken();
      await _repo.DesactiveToken(user.Id);
      await _repo.CreateToken(_mapper.Map<Token>(response), user.Id, jwt.TimeValidMin);
      return response;
    }

    public async Task<AuthResponseDto> Login(AuthRequestDto request)
    {
      var user = await _userRepo.GetUserByAuth(request);
      if(user == null) return null;
      return await Authentication(user);
    }

    public async Task<AuthResponseDto> RefreshToken(int idUser)
    {
      var user = await _userRepo.GetUserAuthById(idUser);
      return await Authentication(user);
    }

    public async Task<AuthResponseDto> RegisterUser(AuthRegisterDto register)
    {
      Guid salt = Guid.NewGuid();
      register.Password = PasswordHashSecurity.HashPassword(register.Password, salt);
      var userCreate = _mapper.Map<User>(register);
      var user = await _userRepo.CreateUser(userCreate, salt);

      return await Authentication(user);
    }
    
    public async Task<bool> ValidateRefreshToken(AuthRefreshTokenRequestDto auth, int idUser)
    {
      var tokenValid = await _repo.GetTokenRefresh(auth, idUser);
      if(tokenValid == null) return false;
      else return true;
    }
  }
}