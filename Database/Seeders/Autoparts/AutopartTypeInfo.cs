using SanAndres_Api.Models;

namespace SanAndres_Api.Database.Seeders
{

    public static class AutopartsTypeInfoSeed
    {
        public static List<AutopartTypeInfo> GetSeed() =>
            new List<AutopartTypeInfo>
            {
                new AutopartTypeInfo { Id = 1, Name = "Código general", TypeValue = AutopartTypeInfoEnum.Code },
                new AutopartTypeInfo { Id = 2, Name = "Código alternativo", TypeValue = AutopartTypeInfoEnum.Code },
                new AutopartTypeInfo { Id = 3, Name = "Código de fabricante", TypeValue = AutopartTypeInfoEnum.Code },
                new AutopartTypeInfo { Id = 4, Name = "Medidas (dimensiones)", TypeValue = AutopartTypeInfoEnum.Measures },
                new AutopartTypeInfo { Id = 5, Name = "Peso", TypeValue = AutopartTypeInfoEnum.Measures },
                new AutopartTypeInfo { Id = 6, Name = "Diámetro", TypeValue = AutopartTypeInfoEnum.Measures },
                new AutopartTypeInfo { Id = 7, Name = "Longitud", TypeValue = AutopartTypeInfoEnum.Measures },
                new AutopartTypeInfo { Id = 8, Name = "Contenido del paquete", TypeValue = AutopartTypeInfoEnum.Contains },
                new AutopartTypeInfo { Id = 9, Name = "Material", TypeValue = AutopartTypeInfoEnum.Contains },
                new AutopartTypeInfo { Id = 10, Name = "Color", TypeValue = AutopartTypeInfoEnum.Contains },
                new AutopartTypeInfo { Id = 11, Name = "Cantidad de piezas", TypeValue = AutopartTypeInfoEnum.Contains },
                new AutopartTypeInfo { Id = 12, Name = "Torque", TypeValue = AutopartTypeInfoEnum.Measures },
                new AutopartTypeInfo { Id = 13, Name = "Voltaje", TypeValue = AutopartTypeInfoEnum.Measures },
                new AutopartTypeInfo { Id = 14, Name = "Amperaje", TypeValue = AutopartTypeInfoEnum.Measures }
            };
    }
}