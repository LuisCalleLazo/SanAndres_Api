using SanAndres_Api.Models;

namespace SanAndres_Api.Dtos
{
    public class AutopartToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public List<AutopartInfoDto> Infos { get; set; }
        public List<AutopartAssetDto> Assets { get; set; }
    }
    public class AutopartInfoDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public AutopartTypeInfoEnum Type { get; set; }
    }

    public class AutopartAssetDto
    {
        public int Id { get; set; }
        public string Asset { get; set; }
        public string Description { get; set; }
    }

    public class AutopartBrandToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class AutopartCategoryToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}