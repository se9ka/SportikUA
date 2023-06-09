using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sportik_API.Dal
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string TypeOfProduct { get; set; } = null!;
        public string imgSrc { get; set; } = null!;
    }
}
