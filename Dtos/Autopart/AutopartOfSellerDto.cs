namespace SanAndres_Api.Dtos
{
    public class AutopartOfSellerDto
    {
        public int AutopartId { get; set; }
        public int SellerId { get; set; }

        public int AmountUnit { get; set; }
        public int AmountUnitPublic { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPricePublic { get; set; }
        public decimal WholessalePrice { get; set; }
        public decimal WholessalePricePublic { get; set; }
    }
}