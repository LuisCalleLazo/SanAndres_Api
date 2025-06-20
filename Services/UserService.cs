using AutoMapper;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Security;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class UserService : IUserService
  {
    private readonly IUserRepository _repo;
    private readonly ITRepository _trepo;
    private readonly IMapper _mapper;

    public UserService(IUserRepository repo, IMapper mapper, ITRepository trepo)
    {
      _repo = repo;
      _mapper = mapper;
      _trepo = trepo;
    }

    public async Task<User> GetUserByName(string name) => await _repo.GetUserByName(name);
    public async Task<User> GetUserByEmail(string email) => await _repo.GetUserByEmail(email);

    public async Task<List<UserToListDto>> GetUsers() => _mapper.Map<List<UserToListDto>>(await _trepo.GetAll<User>());

    public async Task<UserToListDto> PatchUser(UserToPatchDto patch, int userId)
    {
      var user = await _repo.GetUserAuthById(userId);
      var userInfo = await _trepo.GetById<UserInfo>(user.Id);
      
      if (patch.Name != null)
        user.Name = patch.Name;
      if(patch.Email != null)
        user.Email = patch.Email;
      if(patch.MomLastName != null)
        userInfo.MomLastName = patch.MomLastName;
      if(patch.DadLastName != null)
        userInfo.DadLastName = patch.DadLastName;
      if(patch.BirthDate != null)
        userInfo.BirthDate = (DateTime)patch.BirthDate;
      if(patch.CityId != null)
        userInfo.CityId = (int)patch.CityId;
      if(patch.Ci != null)
        userInfo.Ci = patch.Ci;
      if(patch.Address != null)
        userInfo.Adress = patch.Address;
      if(patch.Password != null)
      {
        Guid salt = Guid.NewGuid();
        user.Password = PasswordHashSecurity.HashPassword(patch.Password, salt);
        user.PasswordSalt = salt;
      }
      
      
      await _trepo.Update(user);
      await _trepo.Update(userInfo);

      return _mapper.Map<UserToListDto>(user);
    }

    public async Task DeleteUser(int id)
    {
      var user = await _repo.GetUserAuthById(id);
      await _trepo.Remove(user);
    }
  }
}