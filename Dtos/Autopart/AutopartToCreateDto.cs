using SanAndres_Api.Models;

namespace SanAndres_Api.Dtos
{
    public class AutopartToCreateDto
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }

    public class AutopartAssetToCreate
    {
        public IFormFile Asset { get; set; }
        public string Description { get; set; }
        public int AutopartId { get; set; }
    }

    public class AutopartBrandToCreate
    {
        public IFormFile Logo { get; set; }
        public string Name { get; set; }
        public int AutopartId { get; set; }
    }

    public class AutopartInfoToCreate
    {
        public string Value { get; set; }
        public int TypeId { get; set; }
        public int AutopartId { get; set; }
    }

}