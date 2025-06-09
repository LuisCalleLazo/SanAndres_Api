using SanAndres_Api.Models;

namespace SanAndres_Api.Database.Seeders
{

    public static class AutopartsCategorySeed
    {
        public static List<Category> GetSeed() =>
          new List<Category>
          {
            new Category {Id = 1, Name = "JUNTAS"},
            new Category {Id = 2, Name = "AMORTIGUADORES"},
            new Category {Id = 3, Name = "FRENOS"},
            new Category {Id = 4, Name = "SUSPENSIÓN"},
            new Category {Id = 5, Name = "MOTOR"},
            new Category {Id = 6, Name = "TRANSMISIÓN"},
            new Category {Id = 7, Name = "ELECTRICIDAD"},
            new Category {Id = 8, Name = "ESCAPE"},
            new Category {Id = 9, Name = "FILTROS"},
            new Category {Id = 10, Name = "LUCES"},
            new Category {Id = 11, Name = "BATERÍAS"},
            new Category {Id = 12, Name = "NEUMÁTICOS"},
            new Category {Id = 13, Name = "CARROCERÍA"},
            new Category {Id = 14, Name = "ACCESORIOS"},
          };
    }
}