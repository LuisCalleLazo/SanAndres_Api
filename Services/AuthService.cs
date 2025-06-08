using AutoMapper;
using Microsoft.Extensions.Options;
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
    private readonly IOptions<JwtSettings> _config;
    private readonly IMapper _mapper;
    private readonly ITokenRepository _repo;
    private readonly IUserRepository _userRepo;
    private readonly ITRepository _trepo;
    public AuthService(ITokenRepository repo, IOptions<JwtSettings> config, ITRepository trepo, IUserRepository userRepo, IMapper mapper)
    {
      _repo = repo;
      _config = config;
      _trepo = trepo;
      _userRepo = userRepo;
      _mapper = mapper;
    }
    
    public async Task<AuthResponseDto> Authentication(User user)
    {
      var response = new AuthResponseDto();
      response.User = _mapper.Map<UserResponseDto>(user);

      bool isCustomer = await _userRepo.UserIsCustomer(user.Id);
      bool isSeller = await _userRepo.UserIsSeller(user.Id);

      response.CurrentToken = JwtSecurity.GenerateToken(_config.Value, response.User, isSeller, isCustomer);
      response.RefreshToken = JwtSecurity.GenerateRefreshToken();
      await _repo.DesactiveToken(user.Id);
      await _repo.CreateToken(_mapper.Map<Token>(response), user.Id, _config.Value.TimeValidMin);
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
      
      var userInfoCreate = _mapper.Map<UserInfo>(register);
      var user = await _userRepo.CreateUser(userCreate, salt);

      userInfoCreate.Id = user.Id;
      await _trepo.Create(userInfoCreate);

      if (register.SellerOrCustomer)
      {
        var seller = new Seller { Id = user.Id };
        await _trepo.Create(seller);
      }
      else
      {
        var customer = new Customer { Id = user.Id };
        await _trepo.Create(customer);
      }

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