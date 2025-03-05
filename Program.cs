using System.Reflection;
using Billing.Infrastructure.Config;
using SanAndres_Api.Config;
using SanAndres_Api.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Cloudinary
builder.Services.Configure<CloudinarySetting>(builder.Configuration.GetSection("CloudinarySettings"));

// Config Network
// builder.WebHost.ConfigureKestrel(serverOptions =>
// {
//   serverOptions.Listen(System.Net.IPAddress.Any, 5000);  // HTTP
// });

// Controllers
builder.Services.AddControllers();

// Mapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// Cors
string MyAllowSpecificOrigins = "AllowAnyOrigin";
builder.Services.ConfigureCors(MyAllowSpecificOrigins);


// Inyeccion de dependencias
builder.Services.LoadRepositories();
builder.Services.LoadServices();

// Habilitando el contexto de la base de datos
builder.Services.ConfigureContext(builder);

// Jasper Reports Config
builder.Services.Configure<JasperSettings>(builder.Configuration.GetSection("JasperSettings"));

// Endpoints
builder.Services.AddEndpointsApiExplorer();

// Swagger Config
builder.Services.ConfigureSwagger();

// Auth Config
builder.Services.ConfigureAuth(builder);

// Build
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();