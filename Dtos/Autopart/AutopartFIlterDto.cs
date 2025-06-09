namespace SanAndres_Api.Dtos
{
    public class AutopartFilterDto
    {
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
    }
}