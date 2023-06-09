namespace Sportik_API.Bll
{
    public class ProductDTO
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string TypeOfProduct { get; set; } = null!;
        public string imgSrc { get; set; } = null!;
    }
}
