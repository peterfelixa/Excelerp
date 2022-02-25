using ERPPro.DataAccess.Interfaces;
using ERPPro.DataAccess.Repositories;
using ERPPro.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private IProductRepository productRepository { get; set; }

        public ProductController(ILogger<ProductController> logger
            ,IProductRepository _productRepository)
        {
            _logger = logger;
            productRepository = _productRepository;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public Task<IEnumerable<Product>> Post()
        {
            _logger.Log(LogLevel.Information, "Entering Product Post Method");
            return productRepository.GetAllProducts();
        }
    }
}
