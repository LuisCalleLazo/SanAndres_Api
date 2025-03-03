using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace SanAndres_Api.Config
{
  public static class AuthConfig
  {
    public static void ConfigureAuth(this IServiceCollection services, WebApplicationBuilder builder)
    {
      var jwtConfig = builder.Configuration.GetSection("JwtSettings");
      services.AddAuthentication(conf =>
      {
        conf.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        conf.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
      })
        .AddJwtBearer(op => 
        {
          op.RequireHttpsMetadata = false;
          op.SaveToken = true;
          op.TokenValidationParameters = new TokenValidationParameters
          {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ClockSkew = TimeSpan.Zero,
            ValidIssuer = jwtConfig["Issuer"],
            ValidAudience = jwtConfig["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig["Key"]))
          };
        }
      )
        .AddGoogle(googleOptions => 
        {
          googleOptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
          googleOptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecretId"];
        }
      );
    }
  }
}