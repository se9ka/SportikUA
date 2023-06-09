using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sportik_API.Bll;

namespace Sportik_API.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;
        private readonly IMapper _mapper;

        public ProductsController(IProductsService productsService, IMapper mapper)
        {
            this._productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/products")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(await _productsService.GetProductsAsync()));
        }
    }
}
