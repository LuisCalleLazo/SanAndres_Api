using SanAndres_Api.Models;

namespace SanAndres_Api.Database.Seeders
{
  public static class CitySeed
  {
    public static List<City> GetSeed() =>
      new List<City>{
        // Argentina
        new City{ Id = 1, Name = "Buenos Aires", CountryId = 1 },
        new City{ Id = 2, Name = "Córdoba", CountryId = 1 },
        new City{ Id = 3, Name = "Mendoza", CountryId = 1 },
        new City{ Id = 4, Name = "Santa Fe", CountryId = 1 },
        new City{ Id = 5, Name = "Tucumán", CountryId = 1 },
        new City{ Id = 6, Name = "Salta", CountryId = 1 },

        // Bolivia
        new City{ Id = 7, Name = "La Paz", CountryId = 2 },
        new City{ Id = 8, Name = "Cochabamba", CountryId = 2 },
        new City{ Id = 9, Name = "Santa Cruz", CountryId = 2 },
        new City{ Id = 10, Name = "Oruro", CountryId = 2 },
        new City{ Id = 11, Name = "Potosí", CountryId = 2 },
        new City{ Id = 12, Name = "Tarija", CountryId = 2 },
        new City{ Id = 13, Name = "Beni", CountryId = 2 },
        new City{ Id = 14, Name = "Chuquisaca", CountryId = 2 },
        new City{ Id = 15, Name = "Pando", CountryId = 2 },

        // Brasil
        new City{ Id = 16, Name = "São Paulo", CountryId = 3 },
        new City{ Id = 17, Name = "Rio de Janeiro", CountryId = 3 },
        new City{ Id = 18, Name = "Bahía", CountryId = 3 },
        new City{ Id = 19, Name = "Minas Gerais", CountryId = 3 },
        new City{ Id = 20, Name = "Paraná", CountryId = 3 },
        new City{ Id = 21, Name = "Pernambuco", CountryId = 3 },

        // Chile
        new City{ Id = 22, Name = "Santiago Metropolitana", CountryId = 4 },
        new City{ Id = 23, Name = "Valparaíso", CountryId = 4 },
        new City{ Id = 24, Name = "Biobío", CountryId = 4 },
        new City{ Id = 25, Name = "Araucanía", CountryId = 4 },
        new City{ Id = 26, Name = "Coquimbo", CountryId = 4 },

        // Colombia
        new City{ Id = 27, Name = "Bogotá D.C.", CountryId = 5 },
        new City{ Id = 28, Name = "Antioquia", CountryId = 5 },
        new City{ Id = 29, Name = "Valle del Cauca", CountryId = 5 },
        new City{ Id = 30, Name = "Cundinamarca", CountryId = 5 },
        new City{ Id = 31, Name = "Atlántico", CountryId = 5 },

        // Costa Rica
        new City{ Id = 32, Name = "San José", CountryId = 6 },
        new City{ Id = 33, Name = "Alajuela", CountryId = 6 },
        new City{ Id = 34, Name = "Cartago", CountryId = 6 },
        new City{ Id = 35, Name = "Heredia", CountryId = 6 },

        // Cuba
        new City{ Id = 36, Name = "La Habana", CountryId = 7 },
        new City{ Id = 37, Name = "Santiago de Cuba", CountryId = 7 },
        new City{ Id = 38, Name = "Camagüey", CountryId = 7 },
        new City{ Id = 39, Name = "Holguín", CountryId = 7 },

        // Ecuador
        new City{ Id = 40, Name = "Pichincha", CountryId = 8 },
        new City{ Id = 41, Name = "Guayas", CountryId = 8 },
        new City{ Id = 42, Name = "Azuay", CountryId = 8 },
        new City{ Id = 43, Name = "Manabí", CountryId = 8 },

        // El Salvador
        new City{ Id = 44, Name = "San Salvador", CountryId = 9 },
        new City{ Id = 45, Name = "Santa Ana", CountryId = 9 },
        new City{ Id = 46, Name = "La Libertad", CountryId = 9 },
        new City{ Id = 47, Name = "San Miguel", CountryId = 9 },

        // Guatemala
        new City{ Id = 48, Name = "Guatemala", CountryId = 10 },
        new City{ Id = 49, Name = "Quetzaltenango", CountryId = 10 },
        new City{ Id = 50, Name = "Petén", CountryId = 10 },
        new City{ Id = 51, Name = "Huehuetenango", CountryId = 10 },

        // Honduras
        new City{ Id = 52, Name = "Francisco Morazán", CountryId = 11 },
        new City{ Id = 53, Name = "Cortés", CountryId = 11 },
        new City{ Id = 54, Name = "Atlántida", CountryId = 11 },
        new City{ Id = 55, Name = "Yoro", CountryId = 11 },

        // México
        new City{ Id = 56, Name = "Ciudad de México", CountryId = 12 },
        new City{ Id = 57, Name = "Jalisco", CountryId = 12 },
        new City{ Id = 58, Name = "Nuevo León", CountryId = 12 },
        new City{ Id = 59, Name = "Puebla", CountryId = 12 },

        // Nicaragua
        new City{ Id = 60, Name = "Managua", CountryId = 13 },
        new City{ Id = 61, Name = "León", CountryId = 13 },
        new City{ Id = 62, Name = "Matagalpa", CountryId = 13 },
        new City{ Id = 63, Name = "Chinandega", CountryId = 13 },

        // Panamá
        new City{ Id = 64, Name = "Panamá", CountryId = 14 },
        new City{ Id = 65, Name = "Colón", CountryId = 14 },
        new City{ Id = 66, Name = "Chiriquí", CountryId = 14 },
        new City{ Id = 67, Name = "Veraguas", CountryId = 14 },

        // Paraguay
        new City{ Id = 68, Name = "Asunción", CountryId = 15 },
        new City{ Id = 69, Name = "Central", CountryId = 15 },
        new City{ Id = 70, Name = "Alto Paraná", CountryId = 15 },
        new City{ Id = 71, Name = "Itapúa", CountryId = 15 },

        // Perú
        new City{ Id = 72, Name = "Lima", CountryId = 16 },
        new City{ Id = 73, Name = "Cusco", CountryId = 16 },
        new City{ Id = 74, Name = "Arequipa", CountryId = 16 },
        new City{ Id = 75, Name = "Piura", CountryId = 16 },

        // República Dominicana
        new City{ Id = 76, Name = "Santo Domingo", CountryId = 17 },
        new City{ Id = 77, Name = "Santiago", CountryId = 17 },
        new City{ Id = 78, Name = "La Vega", CountryId = 17 },
        new City{ Id = 79, Name = "San Cristóbal", CountryId = 17 },

        // Uruguay
        new City{ Id = 80, Name = "Montevideo", CountryId = 18 },
        new City{ Id = 81, Name = "Canelones", CountryId = 18 },
        new City{ Id = 82, Name = "Maldonado", CountryId = 18 },
        new City{ Id = 83, Name = "Colonia", CountryId = 18 },

        // Venezuela
        new City{ Id = 84, Name = "Distrito Capital", CountryId = 19 },
        new City{ Id = 85, Name = "Zulia", CountryId = 19 },
        new City{ Id = 86, Name = "Carabobo", CountryId = 19 },
        new City{ Id = 87, Name = "Lara", CountryId = 19 },
      };
  }
}
