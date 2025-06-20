using SanAndres_Api.Repositories;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services;
using SanAndres_Api.Services.Interfaces;
using usr_service.Services;

namespace SanAndres_Api.Config
{
  public static class DependencyInjectionConfig
  {
    public static void LoadRepositories(this IServiceCollection services)
    {
      services.AddScoped<ITRepository, TRepository>();
      services.AddScoped<ITokenRepository, TokenRepository>();
      services.AddScoped<IUserRepository, UserRepository>();
    }

    public static void LoadServices(this IServiceCollection services)
    {
      services.AddScoped<IAuthService, AuthService>();
      services.AddScoped<IUserService, UserService>();
      services.AddScoped<ICloudinaryService, CloudinaryService>();
    }
  }
}