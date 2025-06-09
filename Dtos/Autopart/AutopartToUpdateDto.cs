namespace SanAndres_Api.Dtos
{
    public class AutopartOfSellerToUpdateDto
    {
        public int? AmountUnit { get; set; }
        public int? AmountUnitPublic { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitPricePublic { get; set; }
        public decimal? WholessalePrice { get; set; }
        public decimal? WholessalePricePublic { get; set; }
    }
}