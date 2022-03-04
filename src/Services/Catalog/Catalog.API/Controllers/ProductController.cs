using Catalog.Service.Dtos;
using Catalog.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Catalog.API.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProductDto>), (int)HttpStatusCode.OK)]
        public async Task<List<ProductDto>> GetProductsAsync()
        {
            List<ProductDto> productDtos = await this.productService.GetProductsAsync();

            return productDtos;
        }
    }
}
