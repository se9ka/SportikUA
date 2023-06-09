using AutoMapper;
using Sportik_API.Dal;

namespace Sportik_API.Bll
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
