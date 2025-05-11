using SanAndres_Api.Repositories;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Config
{
  public static class DependencyInjectionConfig
  {
    public static void LoadRepositories(this IServiceCollection services)
    {
      services.AddScoped<ITRepository, TRepository>();
      services.AddScoped<ITokenRepository, TokenRepository>();
    }

    public static void LoadServices(this IServiceCollection services)
    {
      services.AddScoped<IAuthService, AuthService>();
    }
  }
}