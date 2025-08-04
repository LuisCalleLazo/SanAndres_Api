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
    }

    public class AutopartBrandToUpdate
    {
        public IFormFile Logo { get; set; }
        public string Name { get; set; }
    }

    public class AutopartInfoToCreate
    {
        public string Value { get; set; }
        public int TypeId { get; set; }
        public int AutopartId { get; set; }
    }

    public class AutopartOfSellerToCreateDto
    {
        public int AutopartId { get; set; }
        public int AmountUnit { get; set; }
        public int AmountUnitPublic { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPricePublic { get; set; }
        public decimal WholessalePrice { get; set; }
        public decimal WholessalePricePublic { get; set; }
    }

}