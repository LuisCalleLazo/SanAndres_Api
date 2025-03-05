using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class AuthService : IAuthService
  {
    private readonly ITRepository _repo;
    public AuthService(ITRepository repo)
    {
      _repo = repo;
    }
  }
}