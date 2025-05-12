using SanAndres_Api.Models;

namespace SanAndres_Api.Database.Seeders
{
  public static class CountrySeed
  {
    public static List<Country> GetSeed() => 
      new List<Country>{
        new Country { Id = 1,  Name = "Argentina", CodePhone = "+54", Photo = null },
        new Country { Id = 2,  Name = "Bolivia", CodePhone = "+591", Photo = null },
        new Country { Id = 3,  Name = "Brasil",  CodePhone = "+55", Photo = null },
        new Country { Id = 4,  Name = "Chile", CodePhone = "+56", Photo = null },
        new Country { Id = 5,  Name = "Colombia", CodePhone = "+57", Photo = null },
        new Country { Id = 6,  Name = "Costa Rica", CodePhone = "+506", Photo = null },
        new Country { Id = 7,  Name = "Cuba", CodePhone = "+53", Photo = null },
        new Country { Id = 8,  Name = "Ecuador", CodePhone = "+593", Photo = null },
        new Country { Id = 9,  Name = "El Salvador", CodePhone = "+503", Photo = null },
        new Country { Id = 10, Name = "Guatemala", CodePhone = "+502", Photo = null },
        new Country { Id = 11, Name = "Honduras", CodePhone = "+504", Photo = null },
        new Country { Id = 12, Name = "México", CodePhone = "+52", Photo = null },
        new Country { Id = 13, Name = "Nicaragua", CodePhone = "+505", Photo = null },
        new Country { Id = 14, Name = "Panamá", CodePhone = "+507", Photo = null },
        new Country { Id = 15, Name = "Paraguay", CodePhone = "+595", Photo = null },
        new Country { Id = 16, Name = "Perú", CodePhone = "+51", Photo = null },
        new Country { Id = 17, Name = "República Dominicana", CodePhone = "+1", Photo = null },
        new Country { Id = 18, Name = "Uruguay", CodePhone = "+598", Photo = null },
        new Country { Id = 19, Name = "Venezuela", CodePhone = "+58", Photo = null }
    };
  }
}