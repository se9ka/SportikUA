using Sportik_API.Dal;

namespace Sportik_API.Bll
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
