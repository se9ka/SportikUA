using Microsoft.EntityFrameworkCore;
using Sportik_API.Dal;

namespace Sportik_API.Bll
{
    public class ProductsService : IProductsService
    {
        private readonly ProductsDbContext _productsDbContext;

        public ProductsService(ProductsDbContext productsDbContext)
        {
            this._productsDbContext = productsDbContext ?? throw new ArgumentNullException(nameof(productsDbContext));
        }
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productsDbContext.Products.ToListAsync();
        }
    }
}
