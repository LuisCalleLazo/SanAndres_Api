
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Database;

namespace Billing.Infrastructure.Config
{
  public static class DatabaseConfig
  {
    public static void ConfigureContext(this IServiceCollection services, WebApplicationBuilder builder)
    {
      var connectionString = builder.Configuration.GetConnectionString("AutoJapDb");
      services.AddDbContext<DataContext>(options =>
      {
        options.UseNpgsql(connectionString, sqlOptions =>
        {
          sqlOptions.CommandTimeout(60);
        });
      });

      services.AddDistributedMemoryCache();
      
      // services.Configure<RequestLocalizationOptions>(options =>
      // {
      //   options.DefaultRequestCulture = new RequestCulture("en-US");
      // });
    }
  }
}
